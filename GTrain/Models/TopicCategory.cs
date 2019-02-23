using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GTrain.Models
{
    public class TopicCategory
    {
        public int CategoryID { get; set; }  //tried 'TopicCategoryID' but needed update in 'Data' 
        public TopicCategory Category { get; set; } //Check on this, does not like if i try to change to 'TopicCategory'

        public int ID { get; set; }
        public Topic Topic { get; set; }
    }
} 