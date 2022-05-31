using ASP.NET_Assignment_04.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Assignment_04.Controllers
{
    public class HomeController : Controller
    {
        private QuizContext context { get; set; }

        public HomeController(QuizContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index(string view = "Quiz")
        {
            // Default view (homepage) is for starting the quiz
            ViewBag.Header = "Pick a quiz!";
            ViewBag.Action = view;

            // If score, then view is for showing the player scores
            if (view == "Score") 
            {
                ViewBag.Header = "View Score"; 
            }

            // Get quizzes from the database
            var quizzes = context.Quizzes.ToList();

            return View(quizzes);
        }


    }
}
