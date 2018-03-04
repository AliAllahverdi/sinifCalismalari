using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewDers.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.name = "Ana Sehifedesiz";
            return View();
        }
       
        public ActionResult Show()
        {
       
            return View();
        }
        public string Show2(string myText)
        {
            StreamWriter writer = new StreamWriter(@"C:\Users\P502\Desktop\ali\ViewDers\tst.txt",append:true);
            
                writer.WriteLine(myText);
                writer.Close();

            StreamReader read = new StreamReader(@"C:\Users\P502\Desktop\ali\ViewDers\tst.txt");
            var s = read.ReadToEnd();
            read.Close();
            return s;
        }
        
        public ActionResult About()
        {

            return View();
        }
    }
}