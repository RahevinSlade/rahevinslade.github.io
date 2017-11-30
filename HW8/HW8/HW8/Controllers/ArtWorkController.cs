using HW8.DAL;
using HW8.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace HW8.Controllers
{
    public class ArtWorkController : Controller
    {
        public ArtistContext db = new ArtistContext();


        public ActionResult ArtWorkView()
        {
            var artworks = db.ArtWorks.Include(a => a.Artist1);
            return View(artworks.ToList());
        }

    }
}