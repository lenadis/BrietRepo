using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Briet.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Bríet is a groundbreaking community where everyone can help make a difference";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Join the movement and help create subtitles for your favorite movies";

            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Translate()
        {
            return View();
        }
    }
}