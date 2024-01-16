using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal class Bishop : Unit
    {
        private int _recovery;
        private int _energy;

        public int Recovery { get { return _recovery; } set { _recovery = value; } }
        public int Energy { get => _energy; set { _energy = value; } }
        public Bishop() : base(200, "Bishop", true) { _recovery = 1; _energy = 60; }
        public void GetHealth(Unit unit, Bishop bishopunit)
        {   
            while (unit.Health!= unit.MaxHealth && bishopunit.Energy>=2)
            {
                unit.Health += _recovery;
                bishopunit.Energy -= 2;
            }
        }

        public override void ShowInfo()
        {
            if(Life)
            {
                Console.WriteLine($"Unit: {Name} Health: {Health} Energy: {Energy}");
            }
            else base.ShowInfo();
        }
    }
}
