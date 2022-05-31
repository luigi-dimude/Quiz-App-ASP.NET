using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Assignment_04.Models
{
    public class Answer
    {
        public string UserAnswer { get; set; }
        public bool IsCorrect { get; set; }

        // No arg constructor sets the user answer to empty string and the user's answer to incorrect
        public Answer()
        {
            this.UserAnswer = "";
            this.IsCorrect = false;
        }
    }
}
