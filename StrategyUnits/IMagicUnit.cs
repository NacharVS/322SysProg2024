using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal interface IMagicUnit : IMilitaryUnit, IInflictDamage, IDefence, IRandomDamgeController
    {
        public int Energy { get; set; }
        public int MaxEnergy { get; set; }
    }
}
