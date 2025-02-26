using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstMVC.Models
{
    public class Register
    {
        public int UserId { get; set; }
        public string UserName { get; set; } 
        public string Email { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public List<string> Hobbies { get; set; }
        public string Role { get; set; }

    }
}