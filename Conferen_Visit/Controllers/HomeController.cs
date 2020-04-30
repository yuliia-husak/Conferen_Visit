using Conferen_Visit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Conferen_Visit.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good morging" : "Good afternoon";
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        //[HttpPost]
        //public ViewResult RsvpForm(GuestResponse guest)
        //{
        //        return View("Thanks", guest);
        //}

        public ViewResult Create()
        {
            return View("Thanks", new GuestResponse());
        }

        public ViewResult Program()
        {
            return View();
        }

    }
}