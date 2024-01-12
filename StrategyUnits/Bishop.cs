using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    
    internal class Bishop : Unit
    {
        private int _heal;
        private int _ener;
        public int Heal
        {
            get { return _heal; }
            set { _heal = value; }
        }
        public int Ener
        {
            get
            {
                return _ener;
            }
            set { _ener = value; }
        }
        public Bishop() : base(200, "Bishop", 100)
        {
            _heal = 1;
            _ener = 2;

        }
        public void InflictHeal(Unit unit, Bishop bishop)
        {
            while (unit.Health != unit._MaxHealth && bishop.Energy >=2)
            {
                unit.Health += _heal;
                bishop.Energy -= _ener;
            }
        }
    }
}
