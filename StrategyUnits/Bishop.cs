using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Bishop : Unit
    {
        private int _healPoints;

        public int HealPoints
        {
            get { return _healPoints; }
            set { _healPoints = value; }
        }
        public Bishop() : base(25, "Колдун")
        {
            HealPoints = 5;
        }


        public void Heal(Unit unit)
        {
            unit.Health += HealPoints;
        }
    }
}
