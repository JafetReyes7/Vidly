using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie/Random
        public ActionResult Random()
        {
            //var movie = new Movie() { Name = "Shrek" };
            var movies = new List<Movie>
            {
                new Movie { Name = "Shrek"},
                new Movie { Name = "Shrek 2"}
            };
            var customers = new List<Customer>
            {
                new Customer { Name = "John Doe"},
                new Customer { Name = "Jane Doe"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movies = movies,
                Customers = customers
            };
            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("id = " + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

        [Route("movie/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseYear(int year, int month)
        {
            return Content(year + "/" + month);
        }

        [Route("Movies/")]
        public ActionResult Movies()
        {
            var movies = new List<Movie>
            {
                new Movie { Name = "Shrek 1", Id = 1},
                new Movie { Name = "shrek 2", Id = 2}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movies = movies
            };

            return View(viewModel);

        }

        [Route("Customers/")]
        public ActionResult Customers()
        {
            var customers = new List<Customer>
            {
                new Customer { Name = "John Doe", Id = 1},
                new Customer { Name = "Jane Doe", Id = 2}
            };
            var viewModel = new RandomMovieViewModel
            {
                Customers = customers
            };

            return View(viewModel);

        }
        [Route("Customers/{id}")]
        public ActionResult CustomerDetail(int id)
        {
            var customers = new List<Customer>
            {
                new Customer { Name = "John Doe", Id = 1},
                new Customer { Name = "Jane Doe", Id = 2}
            };
            


            return View(customers.Find(c => c.Id==id));

        }
    }
}