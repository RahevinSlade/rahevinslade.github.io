using DMV.DAL;
using System.Linq;
using System.Web.Mvc;
using DMV.Models;

namespace DMV.Controllers
{
    public class HomeController : Controller
    {
        //Creates a new Database for us to use
        private PersonContext db = new PersonContext();

        //Landing page
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet] /*This will let the user request for an address change*/
        public ActionResult Request()
        {
            return View();
        }

        [HttpPost] /*This will add them to the database*/
        public ActionResult Request([Bind(Include = "DOB, FullName, rAddress, CSZ, County, nAddress, nCSZ, nCounty, sDate")]Person person)
        {
            if(ModelState.IsValid)
            {
                db.Persons.Add(person);
                db.SaveChanges();
                return RedirectToAction("Awaiting");
            }
            return View();
        }

        //This will allow user to view others awaiting to be updated
        public ActionResult Awaiting()
        {
            return View(db.Persons.ToList());
        }

    }
}