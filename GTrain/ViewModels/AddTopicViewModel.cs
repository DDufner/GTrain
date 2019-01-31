using GTrain.Models;
using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GTrain.ViewModels
{
    public class AddTopicViewModel
    {
        [Required]
        [Display(Name = "Topic")]
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryID { get; set; }

        public List<SelectListItem> Categories { get; set; }

        public AddTopicViewModel()
        {
        }

        /*public AddTopicViewModel(IEnumerable<TrainingCategory> categories)
        {
            Categories = new List<SelectListItem>();
            foreach (var category in categories)
            {
                Categories.Add(new SelectListItem { Value = category.ID.ToString(), Text = category.Name });
            }
        }*/
    }
}
