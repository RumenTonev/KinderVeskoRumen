using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [OutputCache(Duration = 3600, VaryByParam = "none")]
    public class AdminUploadController : Controller
    {

        public  ApplicationDbContext db = ApplicationDbContext.Create();
   
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

        [HttpGet]
        public ActionResult Multi(string id)
        {
            var model = new SectionDetails();
            //model.FirstTutorial = db.TutoPictures.Where(x => x.TutoNumber == "1" && x.Section == id);
            //model.SecondTutorial = db.TutoPictures.Where(x => x.TutoNumber == "2" && x.Section == id);
            //model.ThirdTutorial = db.TutoPictures.Where(x => x.TutoNumber == "3" && x.Section == id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Kur(Section model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

           TutoPicture tutoPicture = new TutoPicture();

            foreach (var item in model.Files)
            {
                byte[] uploadFile = new byte[item.InputStream.Length];
                item.InputStream.Read(uploadFile, 0, uploadFile.Length);
                tutoPicture.FileName = item.FileName;
                tutoPicture.File = uploadFile;
                tutoPicture.Section = model.Name;
                tutoPicture.TutoNumber = model.TutoNumber;
                db.TutoPictures.Add(tutoPicture);
                db.SaveChanges();
            }

            return Content("File Uploaded.");
        }
    }
}