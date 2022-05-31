using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Assignment_04.Models
{
    public class ResultsViewModel
    {
        public int CorrectAnswers { get; set; }
        public int QuestionCount { get; set; }
        public string ResultMessage { get; set; }
        public int QuizId { get; set; }
    }
}
