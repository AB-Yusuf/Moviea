using Moviea.Models;
using Moviea.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Moviea.Controllers
{
    public class MovieController : Controller
    {


        //[Route("Movie/Index")]
        //GET: Movie
        public ActionResult Index()
        {
            var movies = new List<Movie>
            {
                new Movie {Name = "Shrek"},
                new Movie {Name = "The Avengers"},
                new Movie {Name = "Titanic"}
            };

            return View(movies);
            

        }

       

    }
}