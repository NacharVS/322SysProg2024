using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Barracs
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

        public Paladin CreateArchon()
        {
            return new Paladin(100, 7, 9, "Archon", 5,110);
        }
        public Paladin CreateAncient()
        {
            return new Paladin(110, 12, 13, "Ancient", 8,120);
        }

        public Paladin CreateDivine()
        {
            return new Paladin(150, 17, 20, "Divine", 14,130);
        }
        public Berserk CreateLegendary()
        {
            return new Berserk(150, 15, 16, "Legendary", 4);
        }
        public Zelot CreateEpic()
        {
            return new Zelot(70, 12, 13, "Epic", 2,200);
        }
    }
}
