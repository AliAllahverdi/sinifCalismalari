using session.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace session.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Login(user myUser)
        {


            List<user> istifadeci = new List<user>();
            StreamReader sr = new StreamReader(@"C:\Users\P502\Desktop\disk.txt");
            while (!sr.EndOfStream)
            {
                var thisline = sr.ReadLine();
                var thisData = thisline.Split(';');
                istifadeci.Add(new user()
                {
                    userName = thisData[0],
                    password = thisData[1],
                    isAdmin = thisData[2]
                });
            }
            sr.Close();

            var ad = myUser.userName;
            var parol = myUser.userName;
            var admin = myUser.userName;
            var MyUser = istifadeci.Find(f => f.userName == ad && f.password == parol);
            if(MyUser.isAdmin == "0")
            {
                
            }
            else
            {

            }

            return View();
        }

        public ActionResult SignUp()
        {

            return View();
        }

        [HttpPost]
        public ActionResult SignUp(SignUp mySign)
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\P502\Desktop\disk.txt", append: true);
            sw.WriteLine("Name: " + mySign.Name + ";  " + " Surname:  " + mySign.SurName + ";  " + " Username: " + mySign.userName + ";  " + " Password:  " + mySign.password + ";  " + " Email:  " + mySign.mail + ";  " + " Age:  " + mySign.age + ";  ");
            sw.Close();
            return View("Login");
        }
    }
}