using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal interface IMilitoryUnit
    {
        public int MaxDamage { get; set; }
        public int MinDamage { get; set; }
        public int RandomDamage { get; }
        public void InflictDamage(IHealthController unit);
    }
}
