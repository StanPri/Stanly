﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using Stanly.Models;

namespace Stanly.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult RandomMovie()
        {
            var movie = new Movie(){ Name = "Hulk" };
            return RedirectToAction("RandomBook", "Book");
        }

        public ActionResult SearchMovie(int? pageNumber, string sortBy)
        {
            if (!pageNumber.HasValue)
            {
                pageNumber = 1;

            }
            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }

            return Content(String.Format("pageNumber={0}, SortBy={1}", pageNumber, sortBy));
        }
    }
}