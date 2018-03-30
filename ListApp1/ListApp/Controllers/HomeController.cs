using ListApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ListApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        DBmodel db = new DBmodel();
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(User newUser)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(newUser);
                db.SaveChanges();
                return RedirectToAction("Login");
            }
            
           
            return RedirectToAction("SignUp");
            
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            if (ModelState.IsValid)
            {
                var tapilan = db.Users.FirstOrDefault(f => f.userName == user.userName && f.parol == user.parol);
               

                if (tapilan == null)
                {
                    return View();
                }
                else
                {
                    Session["userName"] = tapilan.userName;
                    Session["isadmin"] = tapilan.isAdmin;
                    Session["status"] = true;
                }

                return RedirectToAction("Index", "Task");
            }

            return View();


        }
    }
}