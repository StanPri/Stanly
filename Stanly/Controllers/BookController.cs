using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Stanly.Models;

namespace Stanly.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult RandomBook()
        {
            var book = new Book(){Name = "Les Miserables"};
            return View(book);
        }
    }
}