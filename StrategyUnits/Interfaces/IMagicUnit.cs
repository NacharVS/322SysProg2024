using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Interfaces
{
    internal interface IMagicUnit
    {
        public int MaxEnergy { get; set; }
        public int EnergySpent { get; }
        public int Energy { get; set; }
    }
}
