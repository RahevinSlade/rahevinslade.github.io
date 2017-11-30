using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HW8.DAL;
using HW8.Models;
using System.Diagnostics;

namespace HW8.Controllers
{
    public class ClassController : Controller
    {
        private ArtistContext db = new ArtistContext();

        public ActionResult ClassView()
        {
            var artClass = db.ArtWorks.Include(c => c.Works);
            return View(artClass.ToList());
        }
    }
}