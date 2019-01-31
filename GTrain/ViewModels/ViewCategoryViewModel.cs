using System;
using GTrain.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GTrain.ViewModels
{
    public class ViewCategoryViewModel
    {
        public IList<TopicCategory> Items { get; set; }
        public Category Category { get; set; }
    }
}