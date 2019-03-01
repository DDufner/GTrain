using System;
using GTrain.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GTrain.ViewModels
{
    public class AddCategoryItemViewModel
    {
        public Category Category { get; set; }
        public List<SelectListItem> Topics { get; set; }
        public int CategoryID { get; set; }
        public int ID { get; set; }
        public Topic Topic { get; set; }

        public AddCategoryItemViewModel() { }

        public AddCategoryItemViewModel(Category category, IEnumerable<Topic> topics)
        {
            Topics = new List<SelectListItem>();

            foreach (var topic in topics)
            {
                Topics.Add(new SelectListItem
                {
                    Value = topic.ID.ToString(),
                    Text = topic.Name
                });
            }
            Category = category;

        }
    }
}