using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            ViewBag.Categories = _movieContext.Categories.ToList();
            return View();
        }
        // For the form submission, passes the form data to the model
        [HttpPost]
        public IActionResult MovieForm(MovieSubmissionModel ms)
        {
            if (ModelState.IsValid)
            {
                _movieContext.Add(ms);
                _movieContext.SaveChanges();
                return View("Confirmation", ms);
            }
            else
            {
                ViewBag.Categories = _movieContext.Categories.ToList();
                return View(ms);
            }
        }
        public IActionResult MovieList ()
        {
            var movies = _movieContext.Responses
                .Include(x => x.Category)
                .ToList();
            return View(movies);
        }
        [HttpGet]
        public IActionResult Edit (int MovieId)
        {
            ViewBag.Categories = _movieContext.Categories.ToList();
            var movie = _movieContext.Responses.Single(x => x.MovieId == MovieId);

            return View("MovieForm", movie);
        }
        [HttpPost]
        public IActionResult Edit (MovieSubmissionModel update)
        {
            if (ModelState.IsValid)
            {
                _movieContext.Update(update);
                _movieContext.SaveChanges();

                return RedirectToAction("MovieList");
            }
            else
            {
                ViewBag.Categories = _movieContext.Categories.ToList();
                return View("MovieForm", update);
            }
        }
        [HttpGet]
        public IActionResult Delete (int MovieId)
        {
            var movie = _movieContext.Responses.Single(x => x.MovieId == MovieId);

            return View(movie);
        }
        [HttpPost]
        public IActionResult Delete (MovieSubmissionModel mo)
        {
            _movieContext.Responses.Remove(mo);
            _movieContext.SaveChanges();

            return RedirectToAction("MovieList");
        }
    }
}
