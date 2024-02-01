using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Interfaces
{
    internal interface ISacredBlow : IMagicUnit
    {
        public int EnergyCost { get; set; }
        public void SacredBlow(IHealthController unit);
    }
}
