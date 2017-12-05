using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Net;
using HW7.Models;

namespace HW7.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        public ActionResult Index()
        {
            return View();
        }
    
        [HttpGet]//here is where we decide what to display
        public JsonResult Search()
        {
            // var selected = $('[name="rate"]:checked').val());

            string rating = Request.QueryString["rating"];

            string url = "https://api.giphy.com/v1/gifs/search?api_key="
               + System.Web.Configuration.WebConfigurationManager.AppSettings["Gkey"]
               // The user's query
               + "&q=" + Request.QueryString["q"]
               + "&rating=" + rating;

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
                gimage.image = data.data[i].images.downsized_medium.url;
                images.Add(gimage);
            }

            return Json(images, JsonRequestBehavior.AllowGet);
        }
    }
}