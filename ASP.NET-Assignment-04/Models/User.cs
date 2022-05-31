using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ASP.NET_Assignment_04.Models
{
    public class User
    {
        [Required]
        [MaxLength(35, ErrorMessage = "Please enter your player name.")]
        public string PlayerName { get; set; }
        [Required]
        [MaxLength(35, ErrorMessage = "Please enter your first name.")]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(35, ErrorMessage = "Please enter your last name.")]
        public string LastName { get; set; }
        
    }
}
