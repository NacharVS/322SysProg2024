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
        public int MaxEnergy { get; set; }
        public int EnergySpent
        {
            get
            {
                return (MaxEnergy - Energy);
            }
        }

        public MagicUnit(int health, string? name) : base (health, name)
        {
            
        }
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
                else if (MaxEnergy < value)
                {
                    _energy = MaxEnergy;
                }
                else
                {
                    _energy = value;
                }
            }
        }
        public void ShowInfoEnergy()
        {
            Console.WriteLine($"Energy: {_energy}");
        }
    }
}
