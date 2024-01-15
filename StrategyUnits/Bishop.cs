using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Bishop: Unit
    {
        private int _healing;

        public int Healing
        {
            get { return _healing; }
            set { _healing = value; }
        }

        public Bishop() : base(60, "Bishop")
        {
            _healing = 60;
        }

        public void HealMagic(Unit unit)
        {
            while()
            
        }
    }
}
