using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string VerifyPassword { get; set; }
        public DateTime DateJoin { get { return DateTime.Now; } }
        
       
        public User()
        {
            
        }
        public User(string username, string email, string password, string verifyPassword)
        {
            Username = username;
            Email = email;
            Password = password;
            VerifyPassword = verifyPassword;
        }
    }
}
