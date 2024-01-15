using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MagicUnit : MiliataryUnit
    {
        protected int _energy;

        public int Energy
        {
            get { return _energy; }
            set
            {
                if (value < 0)
                {
                    _energy = 0;
                }
                else
                {
                    if (value > MaxHeath)
                    {
                        _energy = MaxHeath;
                    }
                    else
                    {
                        _energy = value;
                    }
                }
            }
        }

        public int RemovedEnergy { get => MaxEnergy - Energy; }

        public int MaxEnergy;

        public MagicUnit(int health, string? name, int minDamage, int maxDamage, int defence) : base(health, name, minDamage, maxDamage, defence)
        {
        }
    }
}
