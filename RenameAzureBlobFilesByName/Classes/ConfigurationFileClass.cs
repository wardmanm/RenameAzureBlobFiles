using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenameAzureBlobFilesByName.Classes
{
	public class ConfigurationFileClass
	{
		public string StorageAccountName { get; set; }
		public string StorageAccountKey { get; set; }
		public string ContainerName { get; set; }
	}
}
