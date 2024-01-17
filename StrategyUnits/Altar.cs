using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Altar
    {
        private int _increase;
        public Altar() { _increase = 10; }
        public int Increase
        {
            get 
            { 
                return _increase; 
            }

            set 
            { 
                _increase = value; 
            }
        }
        public void GetIncrease(Bishop bishop1)
        {
            bishop1.Energy += _increase;
        }
    }
}

