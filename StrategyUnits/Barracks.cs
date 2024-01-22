using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Barracks
    {
        public Footman CreateRecruit()
        {
            return new Footman(60, 15, 15, "Recruit", 7);
        }
        public Footman CreateFootman()
        {
            return new Footman(90, 25, 25, "Footman", 10);
        }

        public Footman CreateOfficer()
        {
            return new Footman(120, 35, 35, "Officer", 15);
        }

        public Palladin CreateArchon()
        {
            return new Palladin(100, 7, 9, "Archon", 5, 110);
        }
        public Palladin CreateAncient()
        {
            return new Palladin(110, 12, 13, "Ancient", 8, 120);
        }

        public Palladin CreateDivine()
        {
            return new Palladin(150, 17, 20, "Divine", 14, 130);
        }
    }
}