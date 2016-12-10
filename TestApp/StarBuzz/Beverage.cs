using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarBuzz
{
    public abstract class Beverage
    {
        public string description = "Unknown Beverage";

        public string getDescription()
        {
            return description;
        }

        public abstract double cost();
    }
}
