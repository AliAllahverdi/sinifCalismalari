using models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace models.Controllers
{
    public class HomeController : Controller
    {

        static List<FilmViewModel> vmodel = new List<FilmViewModel>();
        [HttpGet]
        public ActionResult FilmDetails()
        {
         
            vmodel.Add(new FilmViewModel() { FilmsDetails = "Anadolu Kartallari 2010" });
            vmodel.Add(new FilmViewModel() { FilmsDetails = "Dangal 2017" });
            vmodel.Add(new FilmViewModel() { FilmsDetails = "Dhoom 2014" });

            ViewData["testData"] = new User() { username = "Ali" };
            return View();
        }

        [HttpPost]
        public ActionResult FilmDetails(FilmInputDetails FilmsDetail)
        {
            vmodel.Add(new FilmViewModel() {
                FilmsDetails = FilmsDetail.title + " " + FilmsDetail.author + " " + FilmsDetail.year
            });
            return View(vmodel);
        }
    }
}