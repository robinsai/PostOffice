using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostOffice
{


    class Package
    {
        Enum.ItemType itemType;
        int weight;
        public Package(Enum.ItemType itemType,int weight)
        {
            this.weight = weight;
            this.itemType = itemType;
        }
    }
}
