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
    public class ArtWorksController : Controller
    {
        private ArtistContext db = new ArtistContext();

        // GET: ArtWorks
        public ActionResult Index()
        {
            var artWorks = db.ArtWorks.Include(a => a.Artist);
            return View(artWorks.ToList());
        }

        // GET: ArtWorks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ArtWork artWork = db.ArtWorks.Find(id);
            if (artWork == null)
            {
                return HttpNotFound();
            }
            return View(artWork);
        }

        // GET: ArtWorks/Create
        public ActionResult Create()
        {
            ViewBag.ArtistID = new SelectList(db.Artists, "ArtistID", "ArtistName");
            return View();
        }

        // POST: ArtWorks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ArtWorkID,Title,ArtistID")] ArtWork artWork)
        {
            if (ModelState.IsValid)
            {
                db.ArtWorks.Add(artWork);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ArtistID = new SelectList(db.Artists, "ArtistID", "ArtistName", artWork.ArtistID);
            return View(artWork);
        }

        // GET: ArtWorks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ArtWork artWork = db.ArtWorks.Find(id);
            if (artWork == null)
            {
                return HttpNotFound();
            }
            ViewBag.ArtistID = new SelectList(db.Artists, "ArtistID", "ArtistName", artWork.ArtistID);
            return View(artWork);
        }

        // POST: ArtWorks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ArtWorkID,Title,ArtistID")] ArtWork artWork)
        {
            if (ModelState.IsValid)
            {
                db.Entry(artWork).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ArtistID = new SelectList(db.Artists, "ArtistID", "ArtistName", artWork.ArtistID);
            return View(artWork);
        }

        // GET: ArtWorks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ArtWork artWork = db.ArtWorks.Find(id);
            if (artWork == null)
            {
                return HttpNotFound();
            }
            return View(artWork);
        }

        // POST: ArtWorks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ArtWork artWork = db.ArtWorks.Find(id);
            db.ArtWorks.Remove(artWork);
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
