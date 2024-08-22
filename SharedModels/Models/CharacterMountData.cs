using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels.Models
{
    public class CharacterMountData
    {
        public List<MountListItem> mounts {  get; set; }
    }

    public class MountListItem
    {
        public MountListItemChild mount { get; set; }
    }

    public class MountListItemChild
    {
        public int id { get; set; }
    }
}
