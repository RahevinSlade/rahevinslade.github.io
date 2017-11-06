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

        public ActionResult Request()
        {
            return View();
        }

        public ActionResult Awaiting()
        {
            return View(db.Persons.ToList());
        }

    }
}