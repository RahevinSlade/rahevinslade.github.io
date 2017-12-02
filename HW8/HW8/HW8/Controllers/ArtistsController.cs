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

//This controller is where we make the CRUD, and Index
//we also go through and stop users putting their birthday into the future, psssh time travelers

namespace HW8.Controllers
{
    public class ArtistsController : Controller
    {
        private ArtistContext db = new ArtistContext();

        public ActionResult ArtWorks()
        {
            return View(db.ArtWorks.ToList());
        }

        public ActionResult Classifications()
        {
            return View(db.Classifications.ToList());
        }

        // GET: Artists
        public ActionResult Index()
        {
            return View(db.Artists.ToList());
        }

        // GET: Artists/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artist artist = db.Artists.Find(id);
            if (artist == null)
            {
                return HttpNotFound();
            }
            return View(artist);
        }

        // GET: Artists/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Artists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ArtistName,DOB,BirthCity")]  Artist artist)
        {
            string[] DOB = artist.DOB.Split('/');//probably more effective way to check birth days but....
            int ay = Int32.Parse(DOB[2]);
            int am = Int32.Parse(DOB[0]);
            int ad = Int32.Parse(DOB[1]);
            int yyyy = DateTime.Now.Year;
            int mm = DateTime.Now.Month;// jan is month 0
            int dd = DateTime.Now.Day;
            
            if(ay > yyyy)
            {
                TempData["testmsg"] = "<script>alert('Birth day out of bounds ');</script>";
                return View();           
            }
           else if(ay == yyyy && am > mm)
            {
                TempData["testmsg"] = "<script>alert('Birth day out of bounds ');</script>";
                return View();
            }
            else if (ay == yyyy && am == mm && ad > dd)
            {
                TempData["testmsg"] = "<script>alert('Birth day out of bounds ');</script>";
                return View();
            }

            else if (ModelState.IsValid)
            {
                db.Artists.Add(artist);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(artist);
        }

        // GET: Artists/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artist artist = db.Artists.Find(id);

            if (artist == null)
            {
                return HttpNotFound();
            }
            return View(artist);
        }

        // POST: Artists/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Edit(int id, FormCollection artist)
        {
            
            if (ModelState.IsValid)
            {
                var eArtist = db.Artists.Find(id);

                eArtist.ArtistName= artist["ArtistName"];
                eArtist.DOB = artist["DOB"];



                string[] DOB = eArtist.DOB.Split('/');
                int ay = Int32.Parse(DOB[2]);
                int am = Int32.Parse(DOB[0]);
                int ad = Int32.Parse(DOB[1]);
                int yyyy = DateTime.Now.Year;
                int mm = DateTime.Now.Month;// jan is month 0
                int dd = DateTime.Now.Day;

                if (ay > yyyy)
                {
                    TempData["testmsg"] = "<script>alert('Birth day out of bounds ');</script>";
                    return View();
                }
                else if (ay == yyyy && am > mm)
                {
                    TempData["testmsg"] = "<script>alert('Birth day out of bounds ');</script>";
                    return View();
                }
                else if (ay == yyyy && am == mm && ad > dd)
                {
                    TempData["testmsg"] = "<script>alert('Birth day out of bounds ');</script>";
                    return View();
                }

                eArtist.BirthCity = artist["BirthCity"];

                db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: Artists/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var artist = db.Artists.Find(id);
            if (artist == null)
            {
                return HttpNotFound();
            }
            return View(artist);
        }

        // POST: Artists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var artist = db.Artists.Find(id);
            db.Artists.Remove(artist);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
