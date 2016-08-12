using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [OutputCache(Duration = 3600, VaryByParam = "none")]
    public class HomeController : Controller
    {
       public  ApplicationDbContext db = ApplicationDbContext.Create();
        public HomeController()
        {
            
        }
        public ActionResult Index()
        {
            return View();
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

        [HttpPost]
        public ActionResult Kur(MyViewModel model)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View(model);
            //}

            //FileUploadDBModel fileUploadModel = new FileUploadDBModel();

            //foreach (var item in model.File)
            //{
            //    byte[] uploadFile = new byte[item.InputStream.Length];
            //    item.InputStream.Read(uploadFile, 0, uploadFile.Length);

            //    fileUploadModel.FileName = item.FileName;
            //    fileUploadModel.File = uploadFile;

            //    db.FileUploadDBModels.Add(fileUploadModel);
            //    db.SaveChanges();
            //}

            return Content("File Uploaded.");
        }
    }
}