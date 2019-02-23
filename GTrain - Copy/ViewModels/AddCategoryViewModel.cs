using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GTrain.ViewModels
{
    public class AddCategoryViewModel
    {
        [Required]
        [Display(Name = "Category Title")]
        public string Name { get; set; }
        public int ID { get; set; }
    }
}
