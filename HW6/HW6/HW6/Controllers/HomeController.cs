using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Linq;
using System.Web.Mvc;
using HW6.Models;
using System.Net;
using System.Diagnostics;
using HW6.Models;
using System.Data;
using System.Data.Entity;



namespace HW6.Controllers
{
    public class HomeController : Controller
    {
        HW6Context db = new HW6Context();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ProductInfo(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var product = db.Products.Find(id);

            byte[] image = product.ProductProductPhotoes.FirstOrDefault().ProductPhoto.LargePhoto;
            ViewBag.image = "data:image/png;base64," + Convert.ToBase64String(image, 0, image.Length);

            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);

        }

        public ActionResult ComponentProducts(string id)
        {
            string comp = id;
            var Compo = db.Products.Where(s => s.ProductSubcategory.ProductCategory.Name == "Components");
            if (comp == "All")
            {
                ViewBag.Components = "All Components";

                return View(Compo.ToList());
            }
            else
            {
                Compo = db.Products.Where(s => s.ProductSubcategory.Name == comp);
                ViewBag.Components = comp;

                return View(Compo.ToList());

            }
        }


        public ViewResult BikeProducts(string id)
        {
            string Style = id;
            var Bikes = db.Products.Where(s => s.ProductSubcategory.ProductCategory.Name == "Bikes");

            if (Style == "All" || Style == null)
            {
                ViewBag.BikeType = "All Bikes";

                return View(Bikes.ToList());
            }
            else
            {
                Bikes = db.Products.Where(s => s.ProductSubcategory.Name == Style + " Bikes");
                ViewBag.BikeType = Style + " Bikes";

                return View(Bikes.ToList());

            }
        }

        public ViewResult ClothingProduct(string id)
        {
            string Cloth = id;
            var Cloths = db.Products.Where(s => s.ProductSubcategory.ProductCategory.Name == "Clothing");
            if (Cloth == "All" )
            {
                ViewBag.Clothing = "All Clothing";

                return View(Cloths.ToList());
            }
            else
            {
                Cloths = db.Products.Where(s => s.ProductSubcategory.Name == Cloth);
                ViewBag.Clothing = Cloth;

                return View(Cloths.ToList());

            }
        }

        public ActionResult AccessProduct(string id)
        {
            string act = id;
            var Acc = db.Products.Where(s => s.ProductSubcategory.ProductCategory.Name == "Accessories");
            if (act == "All")
            {
                ViewBag.AcessoriesType = "All Accessories";

                return View(Acc.ToList());
            }
            else
            {
                Acc = db.Products.Where(s => s.ProductSubcategory.Name == act);
                ViewBag.AcessoriesTyp = act;

                return View(Acc.ToList());

            }

        }

        [HttpGet]
        public ActionResult UserReview(int? ID)
        {
            ProductReview Review = new ProductReview();
            Review.ProductID = ID ?? 0;

            ViewBag.CurrentProductName = GetProduct(ID);
            return View(Review);
        }

        [HttpPost]
        public ActionResult UserReview(ProductReview Review)
        {
            try
            {
                Review.ModifiedDate = DateTime.Now;
                Review.ReviewDate = DateTime.Now;

                db.Products.Select(p => p.ProductReviews).First().Add(Review);
                db.ProductReviews.Add(Review);
                db.SaveChanges();
                return View("", Review);
            }
            catch(Exception e)
            {
                return View("", Review.ReviewerName);
            }
        }

        private object GetProduct(int? iD)
        {
            int pID = iD ?? 1;
            return db.Products.Where(p => p.ProductID == pID).First();
            throw new NotImplementedException();
        }
    }
}