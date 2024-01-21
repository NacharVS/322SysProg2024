using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Barrac
    {
        public Footman CreateRecruit()
        {
            return new Footman(60, "Recruit", 7);
        }
        public Footman CreateFootman()
        {
            return new Footman(90, "Footman", 10);
        }

        public Footman CreateOfficer()
        {
            return new Footman(120, "Officer", 15);
        }

    }
}
