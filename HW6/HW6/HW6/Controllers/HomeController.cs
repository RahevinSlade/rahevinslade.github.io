using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HW6.Models;
using System.Diagnostics;
using HW6.Models;


namespace HW6.Controllers
{
    public class HomeController : Controller
    {
        HW6Context db = new HW6Context();
        static List<ProductPhoto> image;
        static List<int> imageNum;


        public ActionResult Index()
        {
            var imageList = db.ProductPhotoes.ToList();
            var imageNumList = db.ProductPhotoes.Select(pp => pp.ProductPhotoID);
            image = imageList.ToList<ProductPhoto>();
            imageNum = imageNumList.ToList<int>();

            return View(image);
        }

    }
}