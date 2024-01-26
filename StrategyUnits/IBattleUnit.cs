using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal interface IBattleUnit
    {

        public int attack { get; set; }
        public void InflictDamage(IHealthControl unit);
        public double CountDamage();
        public int DamageMin { get; set; }
        public int DamageMax { get; set; }

        
    }
}
