﻿using System.Web.Mvc;

namespace Vidly.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page 2.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page 1.";



            return View();

        }



    }
}