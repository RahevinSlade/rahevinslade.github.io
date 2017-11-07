using DMV.DAL;
using System.Linq;
using System.Web.Mvc;
using DMV.Models;

namespace DMV.Controllers
{
    public class HomeController : Controller
    {

        private PersonContext db = new PersonContext();

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Request()
        {
            return View();
        }

        [HttpPost]
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


        public ActionResult Awaiting()
        {
            return View(db.Persons.ToList());
        }

    }
}