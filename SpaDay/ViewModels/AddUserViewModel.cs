using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using SpaDay.Models;
using System.Threading.Tasks;

namespace SpaDay.ViewModels
{
    public class AddUserViewModel
    {
        
        [Required(ErrorMessage ="Username is required. Username must be between 5 - 15 characters")]
        [StringLength(15, MinimumLength = 5)]
        public string Username  { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        
        [Required(ErrorMessage ="Password must be between 6 -20 characters")]
        [StringLength(20, MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage ="Passwords must match.")]
        [DataType(DataType.Password)]
        public string VerifyPassword { get; set; }
        public DateTime DateJoin { get { return DateTime.Now; } }
    }
}
