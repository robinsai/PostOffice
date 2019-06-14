using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostOffice
{
    class Package
    {
        public ItemType itemType;
      
        public Package(ItemType itemType)
        {
            this.itemType = itemType;
        }

        public override string ToString()
        {
            return Enum.GetName(typeof(ItemType), itemType);
        }

    }
}
