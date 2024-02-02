using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Barrac
    {
        public Zealot CreateZealot()
        {
            return new Zealot(60, "Zealot", 11, 5, 9, 100);
        }
        public Footman CreateFootman()
        {
            return new Footman(60, "Footman", 5, 14, 19);
        }
        public Berserker CreateBerserker()
        {
            return new Berserker(80, "Berserker", 3, 10, 14);
        }
        public Paladin CreatePalladin()
        {
            return new Paladin(70, "Palladin", 7, 11, 16, 80);
        }
        public Bishop CreateBishop()
        {
            return new Bishop(50, "Bishop", 9, 90);
        }
    }
}
