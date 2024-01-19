using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MilitaryUnit:Unit
    {
        public int _maxdamage { get; set; }
        public int _mindamage { get; set; }

        private Random random = new Random();

        public MilitaryUnit(int health, int mindamage, int maxdamage, string? name, int defence) : base(health, mindamage, maxdamage, name, defence)
        {
            _maxdamage = maxdamage;
            _mindamage = mindamage;
        }

        


        public void InflictDamage(Unit unit)
        {
            unit.Health -= random.Next(_mindamage, _maxdamage) - unit._defence;

        }
    }
}
