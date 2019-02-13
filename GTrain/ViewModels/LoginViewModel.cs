using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GTrain.Models;

namespace GTrain.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        public string UserName { get; set; }
        public string UserID { get; set; }
        public string Password { get; set; }
        //will need password hashing for security 
    }
}
