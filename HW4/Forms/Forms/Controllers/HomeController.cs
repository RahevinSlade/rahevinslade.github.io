using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Net;
using System.Web.Mvc;
using Forms.Models;

namespace Forms.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Convert1()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Convert1")]
        public ActionResult Page1()
        {
            int nume = Int32.Parse(Request.Form["nume"]);
            int denom = Int32.Parse(Request.Form["denom"]);
            string act = Request.Form["act"];

            decimal result;

            if(act == "P" || act == "p")
            {
                result = ((decimal)nume / denom) * 100;
            }
            
            else if(act == "D" || act == "d")
            {
                result = (decimal)nume / denom;
            }

            else
            {
                return Content($"It appears you entered neither a P or a D, so we dont know what you want?");

            }

            return Content($"{result} Ta-Da, here is your result");
        }

       [HttpGet]//this is part two
        public ActionResult Form1()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Form1(FormCollection form)
        {
            string fname = Request.Form["fname"];
            int num = Int32.Parse(Request.Form["num"]);
            string gt;
            if (fname.Length > 3)
            {
                gt = fname.Substring(0, 3) + num.ToString();
            }
            else
            {
                gt = fname + num.ToString();
            }

            ViewBag.newgt = ($"{gt}, is your new gamer tag and my I say, it looks Fabulous!"); 

            return View();
        }

        [HttpGet]
        public ViewResult LoanCalc()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoanCalc(LoanCalc  loanCalc)
        {
            if (ModelState.IsValid)
            {
                return View("bleh", loanCalc);
            }
            else
            {
                return View();
            }
        }
    }
}