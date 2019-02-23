using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GTrain.Models
{
    public class Login
    {
        public string UserName { get; set; }
        public string Email { get; set; }
       /* public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        //will need password hashing for security */
    }
}

