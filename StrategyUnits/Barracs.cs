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
            return new Footman(60,15,15, "Recruit", 7);
        }
        public Footman CreateFootman()
        {
            return new Footman(90,25,25, "Footman", 10);
        }

        public Footman CreateOfficer()
        {
            return new Footman(120,35,35, "Officer", 15);
        }
        
     
    }
}
