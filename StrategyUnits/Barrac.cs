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
            return new Footman(60, "Recruit", 1, 10, 0);
        }
        public Footman CreateFootman()
        {
            return new Footman(90, "Footman", 5, 15, 0);
        }
        public Footman CreateOfficer()
        {
            return new Footman(120, "Officer", 10, 20, 0);
        }
        public Berserker CreateBerserker()
        {
            return new Berserker(100, "Berserker", 5, 8, 0);
        }
        public Palladin CreatePalladin()
        {
            return new Palladin(75, "Palladin", 0, 10, 0, 100);
        }
    }
}
