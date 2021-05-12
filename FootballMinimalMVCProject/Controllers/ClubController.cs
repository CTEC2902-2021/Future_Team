using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FootballMinimalMVCProject.Controllers
{
    public class ClubController : Controller
    {
        // GET: Club
        public string Club(int id)
        {
            return "Club : Id = " + id.ToString();
        }
    }
}