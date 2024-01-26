using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Berserker : Footman
    {
        public Berserker(int health, string name, int minDamage, int maxDamage, int defence) : base(health, name, minDamage, maxDamage, defence)
        {
        }

        public void Frenzy(Unit unit)
        {
            if( Health < MaxHealth * 0.3)
            {
            InflictDamage(unit, 500);
            }
            else{
                System.Console.WriteLine("Cannot be Frenzy");
            }
        }



        
    }
}
