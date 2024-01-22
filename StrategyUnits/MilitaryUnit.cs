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

        public MilitaryUnit(int health, int defence, string? name, int maxdamage, int mindamage) : base(health , defence, name)
        {
            MaxDamage = maxdamage ;
           MinDamage= mindamage; 
        }

        private Random random = new Random();

        public void InflictDamage(Unit unit)
        {
           
            
                double damage = CountDamage();
                unit.GetDamage(damage);
            

        }

        public virtual double CountDamage()
        {
            return random.Next(MinDamage, MaxDamage);
        }

    }
}
