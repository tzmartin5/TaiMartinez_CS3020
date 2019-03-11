using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class Toy : VendingMachineOption
    {
        public int AgeRequirement { get; private set; }
      

        public Toy(string Name, float Price, int Quantity, int ageRequirement) : base (Name, Price, Quantity)
        {
           
            AgeRequirement = ageRequirement;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
