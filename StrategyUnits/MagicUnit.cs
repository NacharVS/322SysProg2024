using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MagicUnit:MilitaryUnit
    {
        private int _energy;
        private int _maxenergy;
        

        public MagicUnit(int health, int mindamage, int maxdamage, string? name,int defence,int energy) : base(health, mindamage, maxdamage, name,defence)
        {
            _energy = energy;
            _maxenergy = _energy;

        }

        public int Energy
        {
            get { return _energy; }
            set { _energy = value; }
        }
        public int MaxEnergy
        {
            get { return _maxenergy; }
        }
        public void InflictHeal(Unit unit)
        {
            while (unit.Health < unit.MaxHealth)
            {
                unit.Health++;
                Altar(2);
            }
        }
    }
}

