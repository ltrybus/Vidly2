using System;
using System.Collections.Generic;
using System.Web.Mvc;
using vidly2.Models;
using vidly2.ViewModels;
using System.Data.Entity;
using System.Linq;

namespace vidly2.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GE
        // GET: Movies
        public ActionResult Index()
        {
            var movies = _context.Movie.Include( m => m.Genres).ToList();
            return View(movies);
        }
        public ActionResult Details(int id)
        {
             var movies = _context.Movie.Include(m => m.Genres).SingleOrDefault(i => i.Id == id);
            if (movies == null)
                return HttpNotFound();
            return View(movies);
        }

        public ActionResult New()
        {
            var genre = _context.Genres.ToList();

            var viewModel = new MovieFormViewModel
            {
                Genres = genre
            };
            return View("MovieForm", viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new MovieFormViewModel
                {
                    Movie = movie,
                    Genres = _context.Genres.ToList()

                };
                return View("MovieForm", viewModel);
            }
            if (movie.Id == 0)
                _context.Movie.Add(movie);
            else
            {
                var movieInDb = _context.Movie.Single(c => c.Id == movie.Id);
                movieInDb.Name = movie.Name;
                movieInDb.RelDate = movie.RelDate;
                movieInDb.GenresId = movie.GenresId;
                movieInDb.QOH = movie.QOH;
                movieInDb.RecDate = movie.RecDate;

                // NFG TryUpdateModel(customerInDb);  
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Movies");
        }

        public ActionResult Edit(int id)
        {
            var movie = _context.Movie.SingleOrDefault(i => i.Id == id);
            if (movie == null)
                return HttpNotFound();
            var viewModel = new MovieFormViewModel
            {
                Movie = movie,
                Genres = _context.Genres.ToList()
            };
            return View("MovieForm", viewModel);
        }



        //   *********************************************************************************************************
        public ActionResult Random()
        {
           
            var movies = new List<Movie>
            {
                new Movie { Name = "Shrek!", Id = 1 },
                new Movie { Name = "Wall-e", Id = 2 },
                new Movie { Name = "Boondock Saints", Id = 3 }
            };
            var customers = new List<Customers>
            {
                new Customers {Name = "John Smith", Id=1},
                new Customers {Name = "Mary Williams", Id=2},
                new Customers {Name = "Jane Doh", Id=3}
            };
            var viewModel = new RandomMovieViewModel
            {
                Movie = movies,
                Customers = customers
            };

            return View(viewModel);

           // return RedirectToAction("Index", "Home", new { page = 1, sortBy = "Name" });
        }



        [Route("movies/released/{year}/{month:regex(\\d{4}): range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            var movie = new Movie() { Name = "Shrek!" };
            return Content(year +"/" + month);
        }
     
      
         
    }
}