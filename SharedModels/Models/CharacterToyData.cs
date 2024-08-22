using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels.Models
{
    public class CharacterToyData
    {
        public List<ToyListItem> toys {  get; set; } 
    }

    public class ToyListItem
    {
        public ToyListItemChild toy {  get; set; }
    }

    public class ToyListItemChild
    {
        public int id { get; set; }
    }
}
