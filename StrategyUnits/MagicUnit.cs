using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MagicUnit : Unit
    {
        private int _healPoints;
        private int _energyPoints;
        private int _energyLimit;
        public int energyLimit
        {
            get { return _energyLimit;}
            set { _energyLimit = value; }
        }
        public int EnergyPoints
        {
            get { return _energyPoints; }
            set { _energyPoints = value; }
        }
        public int HealPoints
        {
            get { return _healPoints; }
            set { _healPoints = value; }
        }
        public MagicUnit(int health, string? name) : base(health, name)
        {

        }
    }
}
