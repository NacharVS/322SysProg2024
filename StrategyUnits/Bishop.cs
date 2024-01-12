using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Bishop : Unit
    {

        private int _healing;

        public int healing
        {
            get { return _healing; }
            set { _healing = value; }
        }
        public Bishop() : base(45, 50, "Bishop")
        {
            _healing = 15;
        }
        public void Healinghealth(Unit unit)
        {
            unit.Health += _healing;
        }


    }
}
