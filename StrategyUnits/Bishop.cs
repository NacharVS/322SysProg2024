using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Bishop : Unit
    {
        private int _hill;
        private int _energy;
        public int MaxEnergy { get; private set; }

        public int Hill
        {
            get { return _hill; }
            set { _hill = value; }
        }

        public int Energy
        {
            get { return _energy; }
            set
            {
                if (value <= 0)
                {
                    _energy = 0;
                }
                else if (value > MaxEnergy)
                {
                    _energy = MaxEnergy;
                }
                else
                {
                    _energy = value;
                }
            }
        }

        public Bishop() : base(20, "Bishop")
        {
            _hill = 1;
            _energy = 60;
            MaxEnergy = _energy;
        }

        public void InFlickHill(Unit unit)
        {
            while (unit.Health < unit.MaxHealth)
            {
                if (Energy <= 0) { break; }
                unit.Health += _hill;
                Energy -= 2;
            }
            
        }
    }
}
