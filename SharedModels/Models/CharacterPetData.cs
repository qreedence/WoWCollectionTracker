using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels.Models
{
    public class CharacterPetData
    {
        public List<PetListItem> pets { get; set; }
    }

    public class PetListItem 
    { 
        public int id { get; set; }
    }
}
