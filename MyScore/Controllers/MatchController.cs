using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyScore.Models;

namespace MyScore.Controllers
{
    public class MatchController : Controller
    {
        // GET: Match
        public ViewResult Index()
        {
            return View();
        }

		[HttpGet]
		public ViewResult NewMatchForm()
		{
			return View();
		}

		[HttpPost]
		public ViewResult NewMatchForm(Match match)
		{
			return View("ShowMatch",match);
		}
    }
}