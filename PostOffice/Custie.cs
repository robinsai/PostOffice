using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostOffice
{
    class Custie
    {
       public Package package;
       public string firstName;
        public string lastName;
        public Custie(Package package, string firstName, string lastName)
        {
            this.package = package;
            this.firstName = firstName;
            this.lastName = lastName;
        }


    }
}
