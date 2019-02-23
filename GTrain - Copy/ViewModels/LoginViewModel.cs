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
        [Required ]
        public string UserName { get; set; }
        public string Email { get; set; }
        /*
        [Required, MinLength(5), MaxLength(50), DataType (DataType.Password)]
        public string Password { get; set; }
        [Required, MinLength(5), MaxLength(50), DataType(DataType.Password)]
        [Compare("Password") ]
        public string ConfirmPassword { get; set; }*/
    }
}
