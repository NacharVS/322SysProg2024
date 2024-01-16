using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MilitaryUnit:Unit
    {
        public int MaxDamage { get; set; }
        public int MinDamage { get; set; }

        public MilitaryUnit(int health, int maxhealth, string? name, int maxdamage, int mindamage) : base(health, maxhealth, name)
        {
            MaxDamage = maxdamage ;
           MinDamage= mindamage; 
        }

        private Random random = new Random();
        public void InflictDamage(Unit unit)
        {
            unit.Health -= random.Next(MinDamage,MaxDamage);
        }


    }
}
