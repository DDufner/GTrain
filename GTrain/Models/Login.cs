using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GTrain.Models
{
    public class Login
    {
        public string UserName { get; set; }
        public int UserID { get; set; }
        public string Password { get; set; }
        //will need password hashing for security 
    }
}

