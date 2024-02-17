using Microsoft.AspNetCore.Mvc;
using Mission6_FilmCollection_Yee.Models;
using System.Diagnostics;

namespace Mission6_FilmCollection_Yee.Controllers
{
    public class HomeController : Controller
    {
        private add_movie_context _context;
        public HomeController(add_movie_context temp) //constructor
        {
            _context = temp;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult add_movie()
        {
            return View("add_movie");
        }

        [HttpPost]
        public IActionResult add_movie(add_movie response)
        {
            _context.Movies.Add(response);
            _context.SaveChanges();

            return View("Confirmation", response);

        }


        public IActionResult get_to_know()
        {
            return View();
        }
    }
}
