using _2018OCT05X1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _2018OCT05X1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index3()
        {
            return "hello world";
        }
        public ViewResult Index2()
        {
            return View();
        }
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult RSVP()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RSVP(GuestResponse gr)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks", gr);
            }
            else
            {
                return View();
            }
        }
    }
}