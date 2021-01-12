using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        //movie
        // ?: optional parameter
        // string => reference para => no need ?
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrEmpty(sortBy))
                sortBy = "Name";
            var movies = new List<Movie>
            {
                new Movie {ID = 1, Name = "Shrek"},
                new Movie {ID = 2, Name = "Wall-e"}
            };
            var viewMovies = new MoviesViewModel
            {
                Movies = movies
            };
            return View(viewMovies);
        }
        // movies/random
        public ActionResult Random()
        {
            var movie = new Movie() {Name = "Sherek!"};
            var customers = new List<Customer>
            {
                new Customer {Name = "Don Don"},
                new Customer {Name = "Don Don 2"},
                new Customer {Name = "Don Don 3"},
                new Customer {Name = "Don Don 4"},
                new Customer {Name = "Don Don 5"},
                new Customer {Name = "Don Don 6"}

            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            

            return View(viewModel);
        }
        // movies/edit/1 or movies/edit?id=1
        // ==> id is default para in routeConfig
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        // movies/released
        [Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}