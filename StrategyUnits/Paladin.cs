using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Paladin : MagicUnit
    {
        public Paladin() : base(30, "Paladin", 10, 6, 3, 8)
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
 
    }
}
