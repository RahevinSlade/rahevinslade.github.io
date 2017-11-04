using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Net;
using System.Web.Mvc;

namespace Forms.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form1()
        {

            string Fname = Request.Form["Fname"];
            string Lname = Request.Form["Lname"];
            Debug.WriteLine($"Hello, {Fname} {Lname}");

            ViewBag.Lname = Lname;
            ViewBag.Fname = Fname;

            
            return View();
        }
    }
}