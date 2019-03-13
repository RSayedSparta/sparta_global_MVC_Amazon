using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AmazonMVC.Models;

namespace AmazonMVC.Controllers
{
    public class AmazonController : Controller
    {
        // GET: Main
        public ActionResult Index()
        {
            //string[,] p = new string[2, 2];
            //p[0, 0] = "Toothbrush";
            //p[0, 1] = "High quality brush";
            //p[0, 2] = "2.99";

            //p[1,0]= "Super Smash Bros 3DS";
            //p[1,1]= "Overpriced and dated game that never reduces is price.";
            //p[1,2]= "47.99";
            //p[2,0]= "Amazon Echo (2nd Gen)";
            //p[2,1]= "The 2nd generation Amazon Echo has a 2.5” downward-firing woofer and 0.6” tweeter powered by Dolby, delivering crisp vocals and dynamic bass throughout the room. You can play music from Amazon Music, Spotify, TuneIn and more. With Amazon Music, you can search by lyrics, time period or let Alexa pick the music for you. ";
            //p[2,2]= "69.99";

            Products p = new Products("Toothbrush","High quality brush, good for your teeth.", 2.99);
            Products p1 = new Products("Super Smash Bros 3DS","Overpriced and dated game that never reduces is price.", 47.99);
            Products p2 = new Products("Amazon Echo (2nd Gen)", "The 2nd generation Amazon Echo has a 2.5” downward-firing woofer and 0.6” tweeter powered by Dolby, delivering crisp vocals and dynamic bass throughout the room. You can play music from Amazon Music, Spotify, TuneIn and more. With Amazon Music, you can search by lyrics, time period or let Alexa pick the music for you. ", 69.99);
            List<Products> prod = new List<Products>();
            prod.Add(p);
            prod.Add(p1);
            prod.Add(p2);
            ViewBag.Products= prod;
            return View();
        }

        public ActionResult Product()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}