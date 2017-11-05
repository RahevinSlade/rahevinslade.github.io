using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Net;
using System.Web.Mvc;
using Forms.Models;

namespace Forms.Controllers// Here is our controller, holding all our fun stuff
{
    public class HomeController : Controller
    {
        // GET: Home, Main page
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]//Here we have a converter, taking two number to a percentage and decimal
        public ActionResult Convert1()
        {//HttpGet, this retrieve the Convert1
            return View();
        }

        [HttpPost]//this posts the data
        [ActionName("Convert1")]
        public ActionResult Page1()
        {//grabs the data, then decides wht to do with it
            int nume = Int32.Parse(Request.Form["nume"]);
            int denom = Int32.Parse(Request.Form["denom"]);
            string act = Request.Form["act"];

            decimal result;
            //if the input is P, p it finds the percentage
            if(act == "P" || act == "p")
            {
                result = ((decimal)nume / denom) * 100;
                result = Math.Round(result, 2);
            }
            //if the input is D, d it finds the decimal version
            else if(act == "D" || act == "d")
            {
                result = (decimal)nume / denom;
                result = Math.Round(result, 4);
            }

            else//if the user decides not to follow the rules
            //we will do nothing for them.
            {
                return Content($"It appears you entered neither a P or a D, so we dont know what you want?");

            }
            //if they did it right, this is what they will retrieve
            return Content($"{result} Ta-Da, here is your result");
        }

        [HttpGet]//this gets the form1 to view
        public ActionResult Form1() => View();

        [HttpPost]//this is where we post the data,   
        public ActionResult Form1(FormCollection form)
        {   //finds the data based on name of the item
            string fname = Request.Form["fname"];
            int num = Int32.Parse(Request.Form["num"]);
            string gt;
            //this where we create the user name
            if (fname.Length > 3)//we want a username the at most 3 letters long
            {
                gt = fname.Substring(0, 3) + num.ToString();
            }
            else//if their name already lessthan or equal to 3, we'll just use that
            {
                gt = fname + num.ToString();
            }
            //we just mash up the two, to create a gamertag
            ViewBag.newgt = ($"{gt}, is your new gamer tag and may I say, it looks Fabulous!"); 

            return View();
        }

        [HttpGet] //Ok, this took a long time to do, 
        //mainly cause I mispelt Loan some how and could not find the error
        public ActionResult Loan()
        {
            return View();
        }

        [HttpPost]//This is where we will post the data and do the functions
        [ActionName("Loan")] //LoanCalc  loanCalc
        public ActionResult LoanAnswer(string amount, string rate, string term)
        {   //finds and converts the data to a double
            double amount1 = Convert.ToDouble( Request.Form["amount"]);
            double rate1 = Convert.ToDouble(Request.Form["rate"]) / 100 ;
            double term1 = Convert.ToDouble(Request.Form["term"]);
            //perform the math one step at a time so its easier to read
            double top = (rate1 * amount1);
            double bottom = (Math.Pow((1 + rate1), (-1 * term1)));

            double payment = top / (1 - bottom);
            //this will round up the double to two decimals points
            payment = Math.Round(payment, 2);

            //we will return a new page with all the information they inputed.
            return  Content($" ${amount} this is the current amount. " +
                $"{rate}% is the rate. " + 
                $"{term} is the number of periods. " +
                $"{payment} is the cost termly. ");
        }
    }
}