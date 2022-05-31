using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Assignment_04.Models
{
    public class QuestionViewModel
    {
        public Question Question { get; set; }
        public List<QuestionOption> Options { get; set; }
        public int QuestionCount { get; set; }
        public int QuestionIndex { get; set; }
        public string UserAnswer { get; set; }
    }
}
