using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Assignment_04.Models
{
    public class Question
    {
        public int QuestionId { get; set; }
        public string Content { get; set; }
        public string Answer { get; set; }
        public Quiz Quiz { get; set; }

    }
}
