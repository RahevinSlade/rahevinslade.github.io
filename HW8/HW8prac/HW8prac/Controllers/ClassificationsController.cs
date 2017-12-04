using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HW8prac.Models;

namespace HW8prac.Controllers
{
    public class ClassificationsController : Controller
    {
        private ArtistContext db = new ArtistContext();

        // GET: Classifications
        public ActionResult Index()
        {
            var classifications = db.Classifications.Include(c => c.ArtWork).Include(c => c.Genre);
            return View(classifications.ToList());
        }

        // GET: Classifications/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Classification classification = db.Classifications.Find(id);
            if (classification == null)
            {
                return HttpNotFound();
            }
            return View(classification);
        }

        // GET: Classifications/Create
        public ActionResult Create()
        {
            ViewBag.ArtWorkID = new SelectList(db.ArtWorks, "ArtWorkID", "Title");
            ViewBag.GenreID = new SelectList(db.Genres, "GenreID", "GenreName");
            return View();
        }

        // POST: Classifications/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ClassificationID,ArtWorkID,GenreID")] Classification classification)
        {
            if (ModelState.IsValid)
            {
                db.Classifications.Add(classification);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ArtWorkID = new SelectList(db.ArtWorks, "ArtWorkID", "Title", classification.ArtWorkID);
            ViewBag.GenreID = new SelectList(db.Genres, "GenreID", "GenreName", classification.GenreID);
            return View(classification);
        }

        // GET: Classifications/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Classification classification = db.Classifications.Find(id);
            if (classification == null)
            {
                return HttpNotFound();
            }
            ViewBag.ArtWorkID = new SelectList(db.ArtWorks, "ArtWorkID", "Title", classification.ArtWorkID);
            ViewBag.GenreID = new SelectList(db.Genres, "GenreID", "GenreName", classification.GenreID);
            return View(classification);
        }

        // POST: Classifications/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ClassificationID,ArtWorkID,GenreID")] Classification classification)
        {
            if (ModelState.IsValid)
            {
                db.Entry(classification).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ArtWorkID = new SelectList(db.ArtWorks, "ArtWorkID", "Title", classification.ArtWorkID);
            ViewBag.GenreID = new SelectList(db.Genres, "GenreID", "GenreName", classification.GenreID);
            return View(classification);
        }

        // GET: Classifications/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Classification classification = db.Classifications.Find(id);
            if (classification == null)
            {
                return HttpNotFound();
            }
            return View(classification);
        }

        // POST: Classifications/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Classification classification = db.Classifications.Find(id);
            db.Classifications.Remove(classification);
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
