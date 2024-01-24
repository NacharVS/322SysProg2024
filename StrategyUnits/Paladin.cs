using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Paladin : MagicUnit
    {
        public void SaintBow(Unit unit)
        {
            if (Energy >= 20)
            {
                unit.GetDamage(20);
                Energy -= 20;

            }
            else
            {
                Console.WriteLine("Недостаточно энергии");
            }

        }


        public Paladin(int health, int defence, string? name, int maxdamage, int mindamage, int energy) : base(health, defence, name, maxdamage, mindamage, energy)
        {
        }

        public void Prayer()
        {
            if (Energy >= 10)
            {
                Energy -= 10;
                GetHeal(20);
            }
            else
            {
                Console.WriteLine("Недостаточно энергии");
            }
        }
    }
}
