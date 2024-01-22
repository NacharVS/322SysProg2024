using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
 
    internal class Berserk : MilitaryUnit
    { 
        public Berserk(int health, int mindamage, int maxdamage, string? name, int defence) : base(health, mindamage, maxdamage, name, defence)
        {
        }
   
        public void Rage()
        {
            if (Health < 0.5 * MaxHealth)
            {
                Health += MaxHealth * 2;
                Console.WriteLine("Berserk in rage");
            }
        }
    }
}