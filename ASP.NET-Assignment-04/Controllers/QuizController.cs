using Microsoft.AspNetCore.Mvc;
using ASP.NET_Assignment_04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ASP.NET_Assignment_04.Controllers
{
    public class QuizController : Controller
    {
        private QuizContext context { get; set; }

        public QuizController(QuizContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public IActionResult Index(int quizId)
        {
            // Get quiz questions from database
            IQueryable<Question> query = context.Questions;
            query = query.Where(
                q => q.Quiz.QuizId == quizId);

            // Get list of questions from query
            List<Question> queryList = query.ToList();

            // Randomly generate a subset of 10 questions from fetched quiz questions
            List<Question> questionSet = QuestionPool.GetSetQuestions(queryList, 10);

            // Create a session and add the question set
            var session = new QuizSession(HttpContext.Session);
            session.SetQuestions(questionSet);

            // Get question count of subset 
            int questionCount = questionSet.Count;

            // Generate a list of answers for the user based on the number of questions
            List<Answer> answers = new List<Answer>();
            foreach (var question in questionSet)
            {
                // Answers initially set to empty string
                var answer = new Answer();
                answers.Add(answer);

            }

            // Add the list to session
            session.SetAnswers(answers);

            // Add quiz id to session
            session.SetQuizId(quizId);

            // Set web page title to the title of the quiz
            ViewData["title"] = context.Quizzes.Find(quizId).Name;

            return View();

        }

        [HttpPost]
        public IActionResult Index(User player)
        {
            // Add player to session
            var session = new QuizSession(HttpContext.Session);
            session.SetQuizPlayer(player);

            // Get current date and add to session before starting the quiz
            DateTime now = DateTime.Now;
            session.SetQuizTime(now);

            // Redirect to quiz
            return RedirectToAction("QuizQuestion");

        }

        [HttpGet]
        public IActionResult QuizQuestion(int questionIndex = 0)
        {
            // Retrieve the questions from sessions
            var session = new QuizSession(HttpContext.Session);
            List<Question> questions = session.GetQuestions();

            // Find a question from the questions list based on the question index
            Question question = questions[questionIndex];

            // Find all the question options from the database
            IQueryable<QuestionOption> query = context.QuestionOptions;
            query = query.Where(q => q.Question.QuestionId == question.QuestionId);
            List<QuestionOption> questionOptions = query.ToList();
            
            // Retrieve user answer for the question
            List<Answer> userAnswers = session.GetAnswers();
            string userAnswer = userAnswers[questionIndex].UserAnswer;

            // Create the view model for the question
            var model = new QuestionViewModel
            {
                Question = question,
                Options = questionOptions,
                QuestionCount = session.GetQuestionsCount(),
                QuestionIndex = questionIndex,
                UserAnswer = userAnswer

            };

            // Set web page title to the title of the quiz
            ViewData["title"] = "Q" + (questionIndex + 1);

            return View(model);
        }

        [HttpPost]
        public RedirectToActionResult QuestionAnswer(int questionIndex, int newQuestionNumber, string userAnswer)
        {
            // Get questions from session
            var session = new QuizSession(HttpContext.Session);
            List<Question> questions = session.GetQuestions();

            // Get answer from session
            List<Answer> answers = session.GetAnswers();
            answers[questionIndex].UserAnswer = userAnswer;

            // Check if player got the right answer
            if (answers[questionIndex].UserAnswer == questions[questionIndex].Answer)
            {
                answers[questionIndex].IsCorrect = true;
            }
            else
            {
                answers[questionIndex].IsCorrect = false;
            }

            // Add new answer in session
            session.SetAnswers(answers);

            // If new question number is -1, it idicates that the quiz is completed
            if (newQuestionNumber == -1)
            {

                // Check for correct answers 
                var correctAnswers = 0;
                foreach (var ans in answers)
                {
                    if (ans.IsCorrect)
                    {
                        correctAnswers++;
                    }
                }

                // Calculate result of the quiz in percentage
                double result = Math.Round(((Double)correctAnswers / (Double)questions.Count), 2);
                result *= 100;

                // Add to result to session
                session.SetQuizResult(result);

                // GET quiz id through sessions
                int quizid = session.GetQuizId();

                // Retrieve the quiz using the quiz id
                Quiz quiz = context.Quizzes.Find(quizid);

                // Create a user score 
                UserScore userscore = new UserScore
                {
                    FirstName = session.GetQuizPlayer().FirstName,
                    LastName = session.GetQuizPlayer().LastName,
                    PlayerName = session.GetQuizPlayer().PlayerName,
                    PlayerScore = result,
                    Quiz = quiz,
                    QuizTime = session.GetQuizTime()

                };

                // Add user score to the database
                context.UserScores.Add(userscore);
                context.SaveChanges();

                // Redirects to quiz result page
                return RedirectToAction("QuizResult");
            }

            // Redirect to new quiz number 
            return RedirectToAction("QuizQuestion", new { questionIndex = newQuestionNumber });
        }

        [HttpGet]
        public IActionResult QuizResult()
        {
            // Get the user's answers from session
            var session = new QuizSession(HttpContext.Session);
            List<Answer> answers = session.GetAnswers();

            // Check for correct answers 
            var correctAnswers = 0;
            foreach (var ans in answers)
            {
                if (ans.IsCorrect)
                {
                    correctAnswers++;
                }
            }

            // Get the user's result from session
            Double result = session.GetQuizResult();

            // Create a message for the user's performance
            string resultMessage = "You have successfully passed the test.";
            if (result < 80)
            {
                resultMessage = "Unfortunately you did not pass the test. Please try again later!";
            }

            // GET quiz id through sessions
            int quizid = session.GetQuizId();

            // Create a view model for the result
            var model = new ResultsViewModel
            {
                CorrectAnswers = correctAnswers,
                QuestionCount = session.GetQuestionsCount(),
                ResultMessage = resultMessage,
                QuizId = quizid

            };

            // Set web page title to the title of the quiz
            ViewData["title"] = "Results";

            return View(model);
        }

    }
}
