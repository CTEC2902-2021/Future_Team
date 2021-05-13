using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            NewsStoryModel newsStory = new NewsStoryModel()
            {
                Headline = "Phew what a scorcher",
                ByLine = "Ron Journo",
                Content = "British people are obsessed with the weather"
            };

            return View(newsStory);
        }
    }
}