using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyFirstMVC.Models;

namespace MyFirstMVC.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            var UserList = new List<User>
            {
                new User{ID =1, Name="Arti", Email="arti123@gmail.com"},
                new User{ID =2, Name="Nikul", Email="nikul123@gmail.com"}

            };

            return View("Index", UserList);
                


        }

        public ContentResult GetUserContent()
        {
            return Content("Id:4, Name: Jaivik, Email: jaivik345@gmail.com");
        }

        public JsonResult GetUserJson()
        {
            var user = new User { ID = 3, Name = "Maulik", Email = "mack123@gmail.com" };

            return Json(user, JsonRequestBehavior.AllowGet);
        }
           
        public ActionResult Details()
        {
            

            var user = new User { ID = 4, Name = "Krishiv", Email = "krishiv213@gmail.com" };

            ViewBag.Message = "This is new user added";
            ViewData["Note"] = "This is viewdata!";

            return View(user);
        }

        public PartialViewResult MyPartialView()
        {
            var user = new User { ID = 5, Name = "Kayra", Email = "kayra213@gmail.com" };

            return PartialView("_UserPartial", user);
        }
        
        public FileResult DownloadFile()
        {
            string filePath = Server.MapPath("~/Files/MyFile.pdf");
            byte[] fileBytes = System.IO.File.ReadAllBytes(filePath);
            return File(fileBytes, "application/pdf", "MyFile.pdf");

        }
    }
}