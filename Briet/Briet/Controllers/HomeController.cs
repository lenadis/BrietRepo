using Briet.DAL;
using Briet.Models;
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
            ViewBag.Message = "Have a Nice Day";
            return View();
        }
        public ActionResult SubtitleList()
        {
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

        public ActionResult Details()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            return View();       
        }
        [HttpPost]
        public ActionResult Edit()
        {
            
            return View();
        }
    }
}