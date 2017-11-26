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
        //creates the db we get to play with and add stuff to
        HW6Context db = new HW6Context();

        public ActionResult Index()
        { //This is the "home"page where we first start out on
            return View();
        }

        public ActionResult ProductInfo(int? id)
        {//The is the product details, displays all spects of the product
            if(id == null)
            {//if we get null id we cant do much but put out a badrequest 
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

        public ActionResult ComponentProducts(string subCategory)
        {//This is where all product compnents are delt with
            string comp = subCategory;// id of the specific item
            //subcategory of the specific item
            var Compo = db.Products.Where(s => s.ProductSubcategory.ProductCategory.Name == "Components");
            if (comp == "Display All")
            {//allows Components to be shared across files
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


        public ViewResult BikeProducts(string subCategory)
        {
            string Style = subCategory;//gets bike id
            //gets the bike subcategory
            var Bikes = db.Products.Where(s => s.ProductSubcategory.ProductCategory.Name == "Bikes");

            if (Style == "Display All" || Style == null)
            {
                //BikeType is now all bikes, to be displayed
                ViewBag.BikeType = "All Bikes";

                return View(Bikes.ToList());
            }
            else
            {
                //subcategory bikes to be dislpayed
                Bikes = db.Products.Where(s => s.ProductSubcategory.Name == Style + " Bikes");
                ViewBag.BikeType = Style + " Bikes";

                return View(Bikes.ToList());

            }
        }

        public ViewResult ClothingProduct(string subCategory)
        {// finds the subCategory that has been assigned during the layout
            string Cloth = subCategory;

            var Cloths = db.Products.Where(s => s.ProductSubcategory.ProductCategory.Name == "Clothing");
            if (Cloth == "Display All" )//used if the user wishes to display all productss
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

        public ActionResult AccessProduct(string subCategory)
        {
            string act = subCategory;
            var Acc = db.Products.Where(s => s.ProductSubcategory.ProductCategory.Name == "Accessories");
            if (act == "Display All")
            {
                ViewBag.AcessoriesType = "All Accessories";

                return View(Acc);
            }
            else
            {
                Acc = db.Products.Where(s => s.ProductSubcategory.Name == act);
                ViewBag.AcessoriesTyp = act;

                return View(Acc.ToList());

            }

        }

        [HttpGet]//creates the review option
        public ActionResult UserReview(int? ID)
        {
            ProductReview Review = new ProductReview();
            Review.ProductID = ID ?? 0;//grabs the review product id, so we know what item has been reviewd

            ViewBag.CurrentProductName = GetProduct(ID);//Finds the product name
            return View(Review);
        }

        [HttpPost]//this will post our review to the site therefor please can review them 
        public ActionResult UserReview(ProductReview Review)
        {
            string id = Review.ProductID.ToString();
            ViewBag.ProductID = id;

            if (ModelState.IsValid)
            {
                Review.ModifiedDate = DateTime.Now;
                Review.ReviewDate = DateTime.Now;

                db.Products.Select(p => p.ProductReviews).First().Add(Review);


                db.ProductReviews.Add(Review);
                db.SaveChanges();
                return Redirect("/Home/ProductInfo/" + id);//redirects back product info page, with new review added
            }

            else
            {//if something goes wrong we will be redirect back the the "home" page
                return RedirectToAction("Index");
            }
        }

        private object GetProduct(int? id)
        {//the asiisting object that allows use to find the product within the database
            int pID = id ?? 1;
            var Product = db.Products.Find(id);
            ViewBag.product = Product.Name;
            return db.Products.Where(p => p.ProductID == pID).First();

            throw new NotImplementedException();
        }
    }
}