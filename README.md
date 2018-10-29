# RenameAzureBlobFiles
A handy little utility to find and rename blob files in Azure Storage.

To use, you need your Azure Storage Account Name, Storage Account Key, and Container Name.  You can type this in manually or load a
custom JSON configuration file.  The JSON should be structured like:

{
    "StorageAccountName": "[Name]",
    "StorageAccountKey": "[Key]",
    "ContainerName": "[Container]"
}

Once you have filled out all three fields the rest runs like a normal find and replace feature.  Find a piece of the filename, a full
filename, or an extension using "Find".  Once you hit "Replace" the utility will first re-check your find field and tell you how many
files will be renamed.  If you say yes to the rename dialog, it will then cycle through the files it finds and replace whatever
your find string is with your replace string.  
