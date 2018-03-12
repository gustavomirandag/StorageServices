using StorageService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public void UploadImage(HttpPostedFileBase myImage)
        {
            var blobService = new BlobService(Common.GetStorageAccount());
            String image = blobService.UploadFile("images", myImage.FileName, myImage.InputStream, myImage.ContentType);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        /*        [HttpPost]
        public void UploadImage(HttpPostedFileBase myImage)
        {
            string containerName = "TestContainer";
            string blockBlogName = "Test.txt";

            CloudStorageAccount cloudStorageAccount = Common.GetStorageAccount();
            BlobService blobService = new BlobService(cloudStorageAccount);
        }*/
    }
}