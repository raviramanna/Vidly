using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        public ViewResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Shrek" },
                new Movie { Id = 2, Name = "Wall-e" }
            };
        }
        // GET: Movies
        public ActionResult Random()
        {
            Movie movie = new Movie {Name = "Shreak"};
            List<Customer> customers = new List<Customer>
            {
                new Customer{Id = 1, Name="Customer A"},
                new Customer{Id = 2, Name="Customer B"},
                new Customer{Id = 1, Name="Customer C"},
                new Customer{Id = 2, Name="Customer D"},
                new Customer{Id = 1, Name="Customer E"},
                new Customer{Id = 2, Name="Customer F"}
            };
            RandomMovieViewModel vm = new RandomMovieViewModel();
            vm.movie = movie;
            vm.customers = customers;
            return View(vm);
        }
    }
}