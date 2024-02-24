using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission6_FilmCollection_Yee.Models;
using System.Diagnostics;

namespace Mission6_FilmCollection_Yee.Controllers
{
    public class HomeController : Controller
    {
        private JoelHiltonMovieCollectionContext _context;
        public HomeController(JoelHiltonMovieCollectionContext temp) //constructor
        {
            _context = temp;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult JoelHiltonMovieCollection()

        {
            ViewBag.Categories = _context.Categories.ToList();
            return View("JoelHiltonMovieCollection");
        }


        [HttpPost]
        public IActionResult JoelHiltonMovieCollection(JoelHiltonMovieCollection response)
        {
            _context.Movies.Add(response);
            _context.SaveChanges();

            return View("Confirmation", response);

        }


        public IActionResult get_to_know()
        {
            return View();
        }

        public IActionResult table()
        {
            var movies = _context.Movies.Include("Category").ToList(); // Fetch movies from database

            return View(movies); // Pass the list of movies to the view
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recordToEdit = _context.Movies
                .Single(x => x.MovieId == id);
            ViewBag.Categories = _context.Categories.ToList();
            return View("JoelHiltonMovieCollection", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(JoelHiltonMovieCollection updatedMovie)
        {
            _context.Update(updatedMovie);
            _context.SaveChanges();
            return RedirectToAction("table");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.Movies
                .Single(x => x.MovieId == id);
            return View(recordToDelete);
        }

        [HttpPost]
        public IActionResult Delete(JoelHiltonMovieCollection updatedMovie)
        {
            _context.Remove(updatedMovie);
            _context.SaveChanges();
            return RedirectToAction("table");
        }
    }
}
