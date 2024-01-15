using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Paladin : MagicUnit
    {
        public Paladin() : base(50, "Паладин", 4, 9, 2, 10)
        {
        }

        public void SaintJuglement(Unit unit)
        {
            if (Energy >= 3)
            {
                unit.GetDamage(RandomDamage() * 2);
                Energy -= 3;
            }
        }
    }
}
