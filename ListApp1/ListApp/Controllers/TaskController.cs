using ListApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ListApp.Controllers
{
    public class TaskController : Controller
    {
        DBmodel db = new DBmodel();
        public ActionResult Index()
        {
           if(Session["status"] == null)
            {
                return RedirectToAction("Login", "Home");
            }
            else
            {
                var tasklist = db.Tasks.Where(w=>w.userid==Session)
                return View()
            }
           
        }
        // GET: Task
        public ActionResult Create()
        {
            if ((bool)Session["isadmin"] == true)
            {
return View();
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public ActionResult Create(Task task)
        {
            if ((bool)Session["isadmin"] == true)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index");
            }
            if (ModelState.IsValid)
            {
                db.Tasks.Add(task);
                db.SaveChanges();
            }

            return View();
        }
    }
}