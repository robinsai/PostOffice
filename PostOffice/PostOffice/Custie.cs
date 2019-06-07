using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostOffice
{
    class Custie
    {
        Package package;
        string firstName;
        string lastName;
        public Custie(Package package, string firstName, string lastName)
        {
            this.package = package;
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public string name()
        {
            char gap = ' ';
            string tempName = (firstName + gap)+lastName;
            return tempName;

        }

    }
}
