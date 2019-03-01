using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GTrain.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }

        //public List<Category> Categories { get; set; }

        public IList<TopicCategory> TopicCategories { get; set; } = new List<TopicCategory>();

    }
}
