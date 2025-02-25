using MyFirstMVC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;


namespace MyFirstMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //create sample user data


            var UserList = new List<User>
            {
                new User{ID =1, Name="Arti", Email="arti123@gmail.com"},
                new User{ID =2, Name="Nikul", Email="nikul123@gmail.com"}

            };

                return View("User", UserList);

            
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
    }
}