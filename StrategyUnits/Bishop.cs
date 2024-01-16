using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal class Bishop : MagicUnit
    {
        private int _recovery;

        public int Recovery { get { return _recovery; } set { _recovery = value; } }
        
        public Bishop() : base(200, "Bishop", true, 100,3, 1) { _recovery = 1;}
        public void GetHealth(Unit unit, Bishop bishopunit)
        {   
            while (unit.Health!= unit.MaxHealth && bishopunit.Energy>=2)
            {
                unit.Health += _recovery;
                bishopunit.Energy -= 2;
            }
        }


    }
}
