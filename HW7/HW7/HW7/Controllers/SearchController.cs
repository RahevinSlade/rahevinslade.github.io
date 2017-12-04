using HW7.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace HW7.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public JsonResult Search() { 
            string url = "https://api.giphy.com/v1/gifs/search?api_key="
               +  System.Web.Configuration.WebConfigurationManager.AppSettings["Gkey"]             
                 // The user's query
               + "&q=" + Request.QueryString["q"]
               + "&rating=g";

            // Create a WebRequest
            WebRequest dataRequest = WebRequest.Create(url);
            Stream dataStream = dataRequest.GetResponse().GetResponseStream();
 

            // Deserialize to the root class from GiphyImage.cs.
            var data = new System.Web.Script.Serialization.JavaScriptSerializer()
                                  .Deserialize<RootObject>(new StreamReader(dataStream)
                              .ReadToEnd());

            List<Giphy> images = new List<Giphy>();
            for (int i = 0; i < 25; i++)
            {
                Giphy gimage = new Giphy();
                gimage.image =  data.data[i].images.downsized_medium.url;
                images.Add(gimage);
            }

            return Json(images, JsonRequestBehavior.AllowGet);
        }
    }
}