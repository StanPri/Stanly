using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Stanly.Models;

namespace Stanly.Controllers
{
    public class SongController : Controller
    {
        // GET: Songs
        public ActionResult RandomSong()
        {
            var song = new Song() {Name = "Amazing Grace"};
            return View(song);
        }
    }
}