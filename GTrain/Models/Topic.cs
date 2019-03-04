using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GTrain.Models
{
    public class Topic
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int ID { get; set; }
        //public DateTime Date { get; set; }
        //public bool Completion {get; set;}

        //public IList<TopicCategory> TopicCategories { get; set; } 
        public IList<TopicCategory> TopicCategories {get; set;}
    }
}
