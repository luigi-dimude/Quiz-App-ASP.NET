using Microsoft.AspNetCore.Mvc;
using ASP.NET_Assignment_04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ASP.NET_Assignment_04.Controllers
{
    public class ScoreController : Controller
    {
        private QuizContext context { get; set; }

        public ScoreController(QuizContext ctx)
        {
            context = ctx;
        }
        public IActionResult Index(int quizId)
        {
            // Get player scores from database return to view
            IQueryable<UserScore> query = context.UserScores;
            query = query.Where(
                u => u.Quiz.QuizId == quizId).OrderByDescending(u => u.PlayerScore);

            List<UserScore> scores = query.ToList();

            // Set web page title to the title of the quiz
            ViewData["title"] = "High Score";

            return View(scores);
        }
    }
}
