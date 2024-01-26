using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Cottage
    {
        public Peasant CreatePeasant()
        {
            return new Peasant(30, "Peasant");
        }
    }
}
