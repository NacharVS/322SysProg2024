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

        private int _healing;
        private int _energy;
        public int healing
        {
            get { return _healing; }
            set { _healing = value; }
        }

        public int energy
        {
            get { return _energy; }
            set { _energy = value; }
        }
        public Bishop() : base(45, 50, "Bishop")
        {
            _healing = 1;
            _energy = 60;
        }
        public void Healinghealth(Unit unit)
        {
            unit.Health += _healing;
            _energy -= 2;

        }

        public void ShowEnergy()
        {
            Console.WriteLine($"Energy: {_energy} ");
        }
    }
}
