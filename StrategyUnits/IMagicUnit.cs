using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal interface IMagicUnit
    {
        public int HealPoints { get; set; }
        public int EnergyPoints { get; set; }
        public int EnergyLimit { get; set; }
        public void Refill(int EnergyAmount);
    }
}
