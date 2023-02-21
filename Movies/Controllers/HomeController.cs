using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Movies.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Controllers
{
    public class HomeController : Controller
    {

        private MovieAppContext _movieContext { get; set; }

        public HomeController(MovieAppContext movieSub)
        {
            _movieContext = movieSub;
        }

        public IActionResult Index()
        {
            return View();
        }
        //Returns Podcast page view
        public IActionResult Podcast()
        {
            return View();
        }
        //Returns Movie Form View
        [HttpGet]
        public IActionResult MovieForm()
        {
            return View();
        }
        // For the form submission, passes the form data to the model
        [HttpPost]
        public IActionResult MovieForm(MovieSubmissionModel ms)
        {
            _movieContext.Add(ms);
            _movieContext.SaveChanges();
            return View("Confirmation", ms);
        }
        public IActionResult MovieList ()
        {
            var movies = _movieContext.Responses.ToList();
            return View(movies);
        }
    }
}
