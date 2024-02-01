using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Interfaces
{
    internal interface IFrenzy : IMilitoryUnit
    {
        public bool FrenzyInfo { get; set; }
        public void Frenzy(IHealthController unit);
    }
}
