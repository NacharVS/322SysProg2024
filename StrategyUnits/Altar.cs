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
            _reserv = 250;
        }
        public void BishopAltar(Bishop bishop)
        {
            while (Reservs > 0 && bishop.energy < 60)
            {

                bishop.energy++;
                Reservs--;
            }


        }
    }
}
