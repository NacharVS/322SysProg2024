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
                unit.Health -= 20;
                Energy -= 20;
            
            }
            else
            {
                Console.WriteLine("Недостаточно энергии");
            }

        }
        public Paladin(): base(45, 50, "Bishop", 3,1, 100)
        {
        }
    }
}
