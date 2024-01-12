using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MagicUnit : Unit
    {
        public int _energy;
        public int Energy
        {
            get
            {
                return _energy;
            }
            set
            {
                if (value < 0)
                {
                    _energy = 0;
                }
                else
                {
                    if (value > MaxHealth)
                    {
                        _energy = MaxHealth;
                    }
                    else
                    {
                        _energy = value;
                    }
                }
            }
        }
        public int RemovedEnergy
        {
            get => MaxEnergy - Energy;
        }

        public int MaxEnergy;
        public MagicUnit(int health, string? name) : base(health, name)
        {
        }
    }
}
