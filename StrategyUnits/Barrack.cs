using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Barrack
    {
        public Footman CreateFootmanRecuit()
        {
            return new Footman(60, "FootmanRecuit", 2,5,0);
        }

        public Footman CreateFootman()
        {
            return new Footman(90, "Footman", 3, 7, 1);
        }

        public Footman CreateFootmanOfficer()
        {
            return new Footman(90, "FootmanOfficer", 15, 22, 2);
        }

        public Berserker CreateBerserker()
        {
            return new Berserker(100, "Berserker", 1, 1, 0);
        }
    }
}
