using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyFirstMVC.Models;

namespace MyFirstMVC.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            //creating empty register 
            Register register = new Register();

            //setting up roles drop down
            ViewBag.Roles = new List<SelectListItem>
            {
                new SelectListItem { Value ="Admin", Text = "Admin"},
                new SelectListItem { Value ="User", Text = "User"},
                new SelectListItem { Value ="Guest", Text = "Guest"}

            };

            // Hobbies
            ViewBag.AvailableHobbies = new List<SelectListItem>
            {
                new SelectListItem { Value ="Reading", Text = "Reading"},
                new SelectListItem { Value ="Traveling", Text = "Traveling"},
                new SelectListItem { Value ="Gaming", Text = "Gaming"},
                new SelectListItem { Value ="Cooking", Text = "Cooking"}
            };





            return View("Index", register);
        }

        // POST: Register/Save
        [HttpPost]
        public ActionResult Save(Register register, string[] Hobbies)
        {
            if (ModelState.IsValid)
            {
                if (Hobbies != null)
                {
                    register.Hobbies = new List<string>(Hobbies);
                }
                else
                {
                    register.Hobbies = new List<string>();
                }

                

                return View("UserData", register);
            }

            // Re-populate dropdown and checkbox data in case of an error.
            ViewBag.Roles = new List<SelectListItem>
            {
                new SelectListItem { Value = "Admin", Text = "Admin" },
                new SelectListItem { Value = "User", Text = "User" },
                new SelectListItem { Value = "Guest", Text = "Guest" }
            };

            ViewBag.AvailableHobbies = new List<SelectListItem>
            {
                new SelectListItem { Value = "Reading", Text = "Reading" },
                new SelectListItem { Value = "Traveling", Text = "Traveling" },
                new SelectListItem { Value = "Gaming", Text = "Gaming" },
                new SelectListItem { Value = "Cooking", Text = "Cooking" }
            };

            return View("Index", register);
        }


        // GET: Register/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Register/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Register/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Register/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Register/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Register/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Register/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
