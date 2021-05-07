using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FootballClub.Controllers
{
    public class FTClubController : Controller
    {
        // GET: FTClub
        public ViewResult  Index()
        {
            ViewBag.Title = "FT Football CLub";
            ViewData["CurrentTime"] = DateTime.Now;
            ViewBag.WelcomeMessage = "Welcome to the Future Team Football Club.";
            ViewBag.Hey = "HEY, HI, HELLO";
            return View();
        }

        public string PremierLeague ()
        {
            return "Premier League Tables";
        }
    }


}