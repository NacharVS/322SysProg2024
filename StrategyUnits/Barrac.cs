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
            return new Footman(100, 150,70,90,  "Recruit", 7);
        }
        public Footman CreateFootman()
        {
            return new Footman(90, 130, 60, 80, "Footman", 10);
        }

        public Footman CreateOfficer()
        {
            return new Footman(110, 120,50,70, "Officer", 15);
        }
        public Paladin CreateEpic()
        {
            return new Paladin(100, 50, 30, 40, "PowerPers",20,6);
        }
        public Paladin CreateLegendary()
        {
            return new Paladin(120, 70, 80, 90, "IntelligencePers", 7,8);
        }
        public Paladin CreateMythical()
        {
            return new Paladin(87, 89, 140, 150, "dexterityPers", 10,10);
        }
        public Berserk CreateRar()
        {
            return new Berserk(150, 15, 16,130, "Rar",10);
        }
        public Zelot CreateChamp()
        {
            return new Zelot(70, 12, 13,15, "Epic", 2,5 );
        }

    }

}
