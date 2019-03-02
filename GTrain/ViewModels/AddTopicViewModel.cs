using GTrain.Models;
using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace GTrain.ViewModels
{
    public class AddTopicViewModel
    {
        private readonly List<Topic> list;

        [Required]
        [Display(Name = "Topic")]
        public string Name { get; set; }
        public string Description { get; set; }
        //public int ID { get; set; }

        //public List<SelectListItem> Topics { get; set; }

        public AddTopicViewModel()
        {
        }
        public AddTopicViewModel(List<Topic> list)
        {
            this.list = list;
        }
        /*
public AddTopicViewModel(IEnumerable<TrainingCategory> categories)
{
   Categories = new List<SelectListItem>();
   foreach (var category in categories)
   {
       Categories.Add(new SelectListItem { Value = category.ID.ToString(), Text = category.Name });
   }
}
*/
    }
}
