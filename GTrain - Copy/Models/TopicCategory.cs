using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GTrain.Models
{
    public class TopicCategory
    {
        public int CategoryID { get; set; }
        public TopicCategory Category { get; set; } //Check on this

        public int ID { get; set; }
        public Topic Topic { get; set; }
    }
}
