using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Factory
    {
        public Footman CreateFootman()
        {
            return new Footman(60, 0, "Footman", 7, 1);
        }
        public Peasant CreatePeasant()
        {
            return new Peasant (30, 1, "Peasant");
        }
        public Bishop CreateBishop()
        {
            return new Bishop(45, 50, "Bishop", 3, 1, 60);
        }
        public Berserker CreateBerserker()
        {
            return new Berserker(80, 5, "Berserker", 13, 7);
        }
        public Zealot CreateZealot()
        {
            return new Zealot(75, 10, "Zealot", 15, 8, 80);
        }
        public Paladin CreatePaladin()
        {
            return new Paladin(45, 50, "Paladin", 3, 1, 100);
        }
     
    }
}
