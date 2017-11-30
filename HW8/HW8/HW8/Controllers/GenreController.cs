using HW8.DAL;
using HW8.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW8.Controllers
{
    public class GenreController : Controller
    {
        public ArtistContext db = new ArtistContext();

        public ActionResult GenreView()
        {
            return View(db.Genres.ToList());
        }

    }
}