using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Interfaces
{
    internal interface IMilitaryUnit
    {
        public int DamageMin { get; set; }
        public int DamageMax { get; set; }

        public void Attack(IHealthControll unit);
    }
}
