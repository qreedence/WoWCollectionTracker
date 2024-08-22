using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels.Models
{
    public class Toy
    {
        public int id { get; set; }
        public ToyItem item { get; set; }
        public Source source { get; set; }
        public Media media { get; set; }    
        public MediaObject mediaObject { get; set; }

        public Item itemObject { get; set; }
    }

    public class ToySummary
    {
        public List<ToyBlizzardListing> toys { get; set; }
    }

    public class ToyBlizzardListing
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class ToyItem
    {
        public Key key { get; set; }
        public string name { get; set; }
        public int id { get; set; }
    }
}
