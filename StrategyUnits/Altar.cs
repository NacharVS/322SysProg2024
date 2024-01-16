using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Altar
    {
        private int _magnifier;
        public Altar() { _magnifier = 10; }
        public int Magnifier
        {
            get { return _magnifier; }
            set { _magnifier = value; }
        }

        public void GetMagnafier(Bishop bishop) 
        {
            bishop.Energy += _magnifier;
        }

        }
    }
