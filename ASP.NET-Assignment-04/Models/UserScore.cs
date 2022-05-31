using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Assignment_04.Models
{
    public class UserScore
    {
        public int UserScoreId { get; set; }
        public string PlayerName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Quiz Quiz { get; set; }
        public DateTime QuizTime { get; set; }
        public double PlayerScore { get; set; }
    }
}
