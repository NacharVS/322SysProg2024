using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Interfaces
{
    internal interface IHealerUnit
    {
        public int Heal { get; set; }
        public void Healing (IHealthControll unit);
    }
}
