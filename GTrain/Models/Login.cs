using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GTrain.Models
{
    public class Login
    {
        //Add user type declaration, i.e. 'admin', 'trainer', 'trainee'

        public string UserEmail { get; set; }
        public int LoginID { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        
        //will need password hashing for security???
    }
}
