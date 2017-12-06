using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Final.Models;

namespace Final.Controllers
{
    public class BidsController : Controller
    {
        private FinalContext db = new FinalContext();

        // GET: Bids
        public ActionResult Index()
        {
            var bids = db.Bids.Include(b => b.Buyer).Include(b => b.Item);
            return View(bids.ToList());
        }

        // GET: Bids/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bid bid = db.Bids.Find(id);
            if (bid == null)
            {
                return HttpNotFound();
            }
            return View(bid);
        }

        // GET: Bids/Create
        public ActionResult Create()
        {
            ViewBag.BuyerID = new SelectList(db.Buyers, "BuyerID", "Buyername");
            ViewBag.ItemID = new SelectList(db.Items, "ItemID", "ItemName");
            return View();
        }

        // POST: Bids/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BidID,ItemID,BuyerID,Price,Stamp")] Bid bid)
        {
            if (ModelState.IsValid)
            {
                bid.Stamp = DateTime.Now;
                db.Bids.Add(bid);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.BuyerID = new SelectList(db.Buyers, "BuyerID", "Buyername", bid.BuyerID);
            ViewBag.ItemID = new SelectList(db.Items, "ItemID", "ItemName", bid.ItemID);
            return View(bid);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public JsonResult Bidders(int id)
        {

            var bids = db.Items.Find(id).Bids.ToList().OrderByDescending(b => b.Price).Select(a => new { b = a.BuyerID, c = a.BidID }).ToList();

            string[] bidmaker = new string[bids.Count];

            for (int i = 0; i < bidmaker.Length; i++)
            {
                bidmaker[i] = $"<ul>{db.Buyers.Find(bids[i].b).Buyername} bid ${db.Bids.Find(bids[i].c).Price}</ul>";
            }

            var data = new { arr = bidmaker };
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        //public JsonResult Item(int id)
        //{
        //   // var artwork = db.Bids.Find(id).Item.OrderBy(t => t).Select(a => new { aw = a.., awa = a.ArtWork.ArtistID }).ToList();
        //    //string[] artworkCreator = new string[artwork.Count()];
        //    //for (int i = 0; i < artworkCreator.Length; ++i)
        //    //{
        //    //    artworkCreator[i] = $"<ul>{db.Bids.Find(artwork[i].aw).Title} by {db.Bids.Find(artwork[i].awa).BuyerID}</ul>";
        //    //}
        //    //var data = new
        //    //{
        //    //    arr = artworkCreator
        //    //};

        //    return Json(data, JsonRequestBehavior.AllowGet);
        //}

    }
}
