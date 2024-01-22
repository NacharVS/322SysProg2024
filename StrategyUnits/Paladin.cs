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
        public Paladin(int health, string? name, int minDamage, int maxDamage, int defence, int energy) : base(45, 50, "Bishop", 3, 1, 100)
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
