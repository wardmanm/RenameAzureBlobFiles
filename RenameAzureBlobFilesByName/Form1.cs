using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;
using RenameAzureBlobFilesByName.Classes;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RenameAzureBlobFilesByName
{
	public partial class MainForm : Form
	{
		StorageCredentials cred = null;
		CloudBlobContainer container = null;
		int fileCount = 0;

		public MainForm()
		{
			InitializeComponent();

			storageAccountKeyTextBox.TextChanged += StorageAccountKeyTextBox_TextChanged;
			storageAccountNameTextBox.TextChanged += StorageAccountNameTextBox_TextChanged;
			containerTextBox.TextChanged += ContainerTextBox_TextChanged;
			findNameTextBox.TextChanged += FindNameTextBox_TextChanged;
		}

		private void findBtn_Click(object sender, EventArgs e)
		{
			bool replaceBtnEnabled = replaceBtn.Enabled;

			resultsBox.Items.Clear();
			fileCount = 0;

			if (cred == null && container == null)
			{
				cred = new StorageCredentials(storageAccountNameTextBox.Text, storageAccountKeyTextBox.Text);
				container = new CloudBlobContainer(new Uri("http://" + storageAccountNameTextBox.Text + ".blob.core.windows.net/" + containerTextBox.Text + "/"), cred);
			}

			var list = container.ListBlobs();

			ButtonsDisabledWorking();

			IterateThroughFolders(list, false, false);

			resultsBox.Items.Add("----------------------------------------------------------");
			resultsBox.Items.Add(fileCount + " files found that matched your search criteria!");
			resultsBox.TopIndex = resultsBox.Items.Count - 1;

			ButtonsReenabledWorking(replaceBtnEnabled);
		}

		private void replaceBtn_Click(object sender, EventArgs e)
		{
			fileCount = 0;
			if (cred == null && container == null)
			{
				cred = new StorageCredentials(storageAccountNameTextBox.Text, storageAccountKeyTextBox.Text);
				container = new CloudBlobContainer(new Uri("http://" + storageAccountNameTextBox.Text + ".blob.core.windows.net/" + containerTextBox.Text + "/"), cred);
			}

			var list = container.ListBlobs();

			ButtonsDisabledWorking();

			IterateThroughFolders(list, true, false);

			var confirmResult = MessageBox.Show("You will be renaming " + fileCount + " files! Do you wish to continue?",
						 "Rename Files",
						 MessageBoxButtons.YesNo);
			if (confirmResult == DialogResult.Yes)
			{
				fileCount = 0;
				IterateThroughFolders(list, false, true);
			}

			resultsBox.Items.Add("----------------------------------------------------------");
			resultsBox.Items.Add(fileCount + " files were renamed!");
			resultsBox.TopIndex = resultsBox.Items.Count - 1;

			ButtonsReenabledWorking(true);
		}

		private void openToolStripButton_Click(object sender, EventArgs e)
		{
			string combinedPath = Path.Combine(Directory.GetCurrentDirectory(), "..\\config");

			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.InitialDirectory = Path.GetFullPath(combinedPath);
			openFileDialog.Filter = "JSON Files|*.json";
			openFileDialog.Title = "Select an Azure Configuration";

			// Show the Dialog.  
			// If the user clicked OK in the dialog and a .JSON file was selected, open it. 
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				var fileStream = openFileDialog.OpenFile();
				using (StreamReader sr = new StreamReader(fileStream))
				{
					ConfigurationFileClass configFile = JsonConvert.DeserializeObject<ConfigurationFileClass>(sr.ReadToEnd());
					if (configFile != null)
					{
						storageAccountNameTextBox.Text = configFile.StorageAccountName;
						storageAccountKeyTextBox.Text = configFile.StorageAccountKey;
						containerTextBox.Text = configFile.ContainerName;
					}
				}
			}
		}

		//Recursively iterate through blob storage and find file names that need to change (and replace if needed)
		private void IterateThroughFolders(IEnumerable<IListBlobItem> items, bool getCountOnly, bool replace)
		{

			foreach (var x in items)
			{
				//If the current blob is a directory, drill down recursively until we hit some actual files
				if (x.GetType() == typeof(CloudBlobDirectory))
				{
					CloudBlobDirectory folder = (CloudBlobDirectory)x;
					IEnumerable<IListBlobItem> folderBlobs = folder.ListBlobs();
					IterateThroughFolders(folderBlobs, getCountOnly, replace);
				}
				else
				{
					//If the user didn't enter anything or just entered a space, pretty much return everything you find that is a file
					if (string.IsNullOrWhiteSpace(findNameTextBox.Text))
					{
						if (!getCountOnly)
						{
							resultsBox.Items.Add("Uri: " + x.Uri);
						}
						fileCount++;
					}
					else
					{
						//Get rid of all of the uri string except for the filename to search
						string uriString = x.Uri.ToString().ToLower();
						string findString = Uri.EscapeDataString(findNameTextBox.Text.ToLower());

						int pos = uriString.LastIndexOf("/") + 1;
						//Look for the user's search term
						if (uriString.Substring(pos, uriString.Length - pos).Contains(findString))
						{
							if (!getCountOnly && !replace)
							{
								resultsBox.Items.Add("Uri: " + x.Uri);
							}
							else if (replace)
							{
								ReplaceBlobFileName(x);
							}
							fileCount++;
						}
					}
				}
			}
		}

		private void ReplaceBlobFileName(IListBlobItem blob)
		{
			resultsBox.Items.Add("----------------------------------------------------------");
			string uriString = blob.Uri.ToString();
			resultsBox.Items.Add(uriString + " RENAMED TO:");

			int pos = uriString.LastIndexOf("/") + 1;
			string preChangeFileName = uriString.Substring(pos, uriString.Length - pos);
			string postChangeFileName = preChangeFileName.Replace(findNameTextBox.Text, replaceTextBox.Text);
			string newUriString = uriString.Replace(preChangeFileName, postChangeFileName);

			CopyAndRenameBlobFile(uriString, newUriString);
			resultsBox.Items.Add(newUriString);
		}

		private async Task CopyAndRenameBlobFile(string oldUriString, string newUriString)
		{

			string oldFileName = GetNameFromUriString(oldUriString);
			string newFileName = GetNameFromUriString(newUriString);

			await container.CreateIfNotExistsAsync();

			CloudBlockBlob blobCopy = container.GetBlockBlobReference(newFileName);

			if (!await blobCopy.ExistsAsync())
			{
				CloudBlockBlob blob = container.GetBlockBlobReference(oldFileName);
				var test = blob.ExistsAsync();

				if (await blob.ExistsAsync())
				{
					await blobCopy.StartCopyAsync(blob);
					await blob.DeleteIfExistsAsync();
				}

			}
		}

		private string GetNameFromUriString(string uriString)
		{
			var stringToRemove = "http://" + storageAccountNameTextBox.Text + ".blob.core.windows.net/" + containerTextBox.Text + "/";

			return uriString.Replace(stringToRemove, "");
		}

		private void StorageAccountKeyTextBox_TextChanged(object sender, EventArgs e)
		{
			ButtonsEnabledDisabled();
		}

		private void StorageAccountNameTextBox_TextChanged(object sender, EventArgs e)
		{
			ButtonsEnabledDisabled();
		}

		private void ContainerTextBox_TextChanged(object sender, EventArgs e)
		{
			ButtonsEnabledDisabled();
		}

		private void FindNameTextBox_TextChanged(object sender, EventArgs e)
		{
			ButtonsEnabledDisabled();
		}

		private void ButtonsDisabledWorking()
		{
			findBtn.Enabled = false;
			findBtn.Text = "Working...";
			replaceBtn.Enabled = false;
			replaceBtn.Text = "Working...";
		}

		private void ButtonsReenabledWorking(bool wasReplaceButtonEnabled)
		{
			findBtn.Enabled = true;
			findBtn.Text = "Find";
			replaceBtn.Text = "Replace";
			if (wasReplaceButtonEnabled)
			{
				replaceBtn.Enabled = true;
			}
		}

		private void ButtonsEnabledDisabled()
		{
			if (!string.IsNullOrWhiteSpace(storageAccountKeyTextBox.Text)
				&& !string.IsNullOrWhiteSpace(storageAccountNameTextBox.Text)
				&& !string.IsNullOrWhiteSpace(containerTextBox.Text))
			{
				findBtn.Enabled = true;

				if (!string.IsNullOrWhiteSpace(findNameTextBox.Text))
				{
					replaceBtn.Enabled = true;
				}
				else
				{
					replaceBtn.Enabled = false;
				}
			}
			else
			{
				findBtn.Enabled = false;
				replaceBtn.Enabled = false;
			}
		}
	}
}
