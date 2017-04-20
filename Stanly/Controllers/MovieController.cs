using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using Stanly.Models;
using Stanly.ViewModel;

namespace Stanly.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ViewResult RandomMovie()
        {
            var movie = getMovies();
            

            return View(movie);
        }

        private IEnumerable<Movie> getMovies()
        {
            return new List<Movie>
            {
                new Movie() {Name="Hulk", Id = 1},
                new Movie() {Name = "Gone with the Wind", Id = 2},
                new Movie() {Name = "Titanic", Id = 3}

            };
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

        [Route("movie/released/{year:regex(\\d{2}):range(1900,2017)}/{month:regex(\\d{2}):range(1,31)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(String.Format("Year={0}, Month={1}", year, month));
        }
    }
}