using RealSurfLab.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RealSurfLab.Controllers
{
    public class MyController : Controller
    {
        // GET: My
        public ActionResult Index()
        {
            var my = new Mymodel {Name = "Стефания", Age = 17 };
            ViewBag.My = my;
            return View();
        }

        public ActionResult AboutMe()
        {




            var my = new Mymodel { Name = "Афафья", Age = 27 };

            ViewBag.Prices = new[] { 100, 120, 140, 99 };

            return View(my);
        }
    }
}