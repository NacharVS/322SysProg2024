using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Altar
    {
        private int _increased;
        public Altar() { _increased = 10; }
        public int Increased
        {
            get { return _increased; }
            set { _increased = value; }
        }

        public void GetIncreased(Bishop bishop)
        {
            bishop.Energy += _increased;
        }

    }
}
