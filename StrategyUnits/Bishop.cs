using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Bishop : Unit
    {
        private int _energy;
        public Bishop() : base(40, "BP")
        {
            _energy = 60;
        }


        public void HealSomebody(Unit unit)
        {
            while (unit.Health < unit.MaxHealth && _energy > 0)
            {
                unit.Health++;
                _energy -= 2;
            }
        }
    }
}
