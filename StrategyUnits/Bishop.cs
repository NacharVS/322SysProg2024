using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Bishop : Unit
    {
        private int _healAmount;
        private int _energy;

        public int Energy
        {
            get { return _energy; }
            set { _energy = value; }
        }

        public int HealAmount
        {
            get { return _healAmount; }
            set { _healAmount = value; }
        }

        public Bishop() : base(50, "Bishop")
        {
            _healAmount = 5;
        }

        public void Heal(Unit unit)
        {
            unit.Health += _healAmount;
        }
    }
}
