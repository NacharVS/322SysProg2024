using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class barrack
    {
        public Footman GetFootman() => new Footman(60, "Footman", 3, 7, 5);
        public Footman CreateRecruit() => new Footman(90, "Recruit", 7, 10, 7);
        public Footman CreateOfficer() => new Footman(120, "Officer", 10, 15, 9);


        //

        public Palladin GetDraenei() => new Palladin(60, "Draenei", 4, 17, 5, 200);
        public Palladin CreateDwarf() => new Palladin(90, " Dwarf", 7, 18, 7, 250);
        public Palladin CreateHuman() => new Palladin(120, "Human", 16, 25, 9, 400);
    }
}
