using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;

namespace StorageService
{
    public class TableService
    {
        public CloudStorageAccount StorageAccount { get; private set; }
        public TableService(CloudStorageAccount cloudStorageAccount)
        {
            StorageAccount = cloudStorageAccount;
        }
    }
}
