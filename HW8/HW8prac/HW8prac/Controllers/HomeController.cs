using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HW8prac.Models;

namespace HW8prac.Controllers
{
    public class HomeController : Controller
    {
        public ArtistContext db = new ArtistContext();

        public ActionResult Index()
        {
            var genres = db.Genres;
            return View(genres);
        }

        public JsonResult Genre(int id)
        {
            var artwork = db.Genres.Find(id).Classifications.ToList().OrderBy(t => t.ArtWork.Title).Select(a => new { aw = a.ArtWorkID, awa = a.ArtWork.ArtistID }).ToList();
            string[] artworkCreator = new string[artwork.Count()];
            for (int i = 0; i < artworkCreator.Length; ++i)
            {
                artworkCreator[i] = $"<ul>{db.ArtWorks.Find(artwork[i].aw).Title} by {db.Artists.Find(artwork[i].awa).ArtistName}</ul>";
            }
            var data = new
            {
                arr = artworkCreator
            };

            return Json(data, JsonRequestBehavior.AllowGet);
        }

    }
}