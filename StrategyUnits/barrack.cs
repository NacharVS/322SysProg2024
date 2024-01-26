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
        
 
        public Berserker GetJKalinudini()  => new Berserker(30, "JKalinudini ", 3, 30 , 8);
        public Berserker GetDrykinRahimi() => new Berserker(40, "Drykin Rahimi", 5 ,20, 5);
        public Berserker GetRagiliRykin() => new Berserker(40, "Ragili Rykin", 5, 15 ,10);


        //

        public Palladin GetDraenei() => new Palladin(60, "Draenei", 4, 17, 5, 200);
        public Palladin CreateDwarf() => new Palladin(90, " Dwarf", 7, 18, 7, 250);
        public Palladin CreateHuman() => new Palladin(120, "Human", 16, 25, 9, 400);

        public Zectof GetZector1() => new Zectof(30 , "Zector1", 1 , 7 ,5, 100);
        public Zectof GetZector2() => new Zectof(30 , "Zector2", 2 , 10 ,15, 100);
        public Zectof GetZector3() => new Zectof(30 , "Zector3", 3 , 15 ,9, 100);

        public Bishop Getbishop1() => new Bishop("bishop1", 15, 1, 4, 5, 70);
        public Bishop Getbishop2() => new Bishop("bishop2", 20, 2, 5, 6, 60);
        public Bishop Getbishop3() => new Bishop("bishop#", 25, 3, 6, 7, 50);


    }
}
