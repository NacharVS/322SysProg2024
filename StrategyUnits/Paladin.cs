using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Paladin : MagicUnit
    {
        public Paladin(int health, string? name, int minDamage, int maxDamage, int defence, int energy) : base(health, name, minDamage, maxDamage, defence, energy)
        {

        }
        public void SaintRow(Unit unit)
        {
            while (unit.Health > 0 & mana > 0)
            {
                unit.Health -= 2;
                mana += 2;
            }
        }
        public void Prayer()
        {
            if (mana >= 10)
            {
                mana -= 10;
                GetHeal(20);
            }
            else
            {
                Console.WriteLine($"У {Name} недостаточно маны для заклинания Prayer");
            }
        }
    }
}
