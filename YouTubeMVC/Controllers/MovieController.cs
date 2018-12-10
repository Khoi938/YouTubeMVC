using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YouTubeMVC.Models;

namespace YouTubeMVC.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie/Random1
        public ActionResult Random1()
        {
            Movie movie = new Movie() { Name = "Alladin", Id = 1 };
            return View(movie);
        }
    }
}