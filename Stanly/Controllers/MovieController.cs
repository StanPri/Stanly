using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Stanly.Models;

namespace Stanly.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult RandomMovie()
        {
            var movie = new Movie(){ Name = "Hulk" };
            return View(movie);
        }
    }
}