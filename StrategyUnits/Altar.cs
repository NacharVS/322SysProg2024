using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Altar
    {
        private int _reserv;
        public int Reservs
        {
            get { return _reserv; }
            set { _reserv = value; }
        }
        public Altar()
        {
            _reserv = 5000;
        }
        public void BishopAltar(Bishop bishop)
        {
            while (Reservs > 0 && bishop.mana < 61)
            {

                bishop.mana++;
                Reservs--;
            }


        }
    }
}
