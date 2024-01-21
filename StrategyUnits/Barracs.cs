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
            return new Footman(60, "Recruit", 1,4,5);
        }
        public Footman CreateFootman()
        {
            return new Footman(90, "Footman", 1,5,6);
        }

        public Footman CreateOfficer()
        {
            return new Footman(120, "Officer", 2, 6, 8);
        }
        public Berserk CreateBerserk()
        {
            return new Berserk(300, "Berserk", 5, 9, 1);
        }
    }
}
