using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Assignment_04.Models
{
    // Question options for a particular question
    public class QuestionOption
    {
        public int QuestionOptionId { get; set; }
        public string Content { get; set; }
        public Question Question { get; set; }
    }
}
