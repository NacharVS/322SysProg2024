using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Interfaces
{
    internal interface IHeal : IMagicUnit
    {
        public int EnergyCost { get; set; }
        public void Healing(IHealthController unit);
    }
}
