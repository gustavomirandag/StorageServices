using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.WindowsAzure.Storage;
using StorageService;

namespace UnitTest.StorageService
{
    [TestClass]
    public class BlobServiceUnitTest
    {
        [TestMethod]
        public void TestUploadImage()
        {
            //Preparando para realizar o teste
            CloudStorageAccount cloudStorageAccount = Common.GetStorageAccount();
            BlobService blobService = new BlobService(cloudStorageAccount);

            try
            {
                blobService.UploadFile("tiger.jpg", "tiger.jpg");
            }
            catch
            {
                Assert.Fail();
            }           
        }
    }
}
