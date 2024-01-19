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

        public void SaintJuglement(Unit unit)
        {
            if (Mana >= 3)
            {
                unit.GetDamage(CountDamage() * 2);
                Mana -= 3;
            }
        }

        public void Prayer()
        {
            if(Mana >= 10) 
            {
                Mana -= 10;
                GetHeal(20);
            }
            else
            {
                Console.WriteLine($"У {Name} недостаточно маны для заклинания Prayer");
            }
        }
    }
}
