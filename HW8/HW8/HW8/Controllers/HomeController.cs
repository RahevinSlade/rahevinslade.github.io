using HW8.DAL;
using HW8.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;


//Welcome to the home controller, this is where we keep the index, and call for the json,. ajax info
namespace HW8.Controllers
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