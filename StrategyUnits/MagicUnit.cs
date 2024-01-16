using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MagicUnit : MilitaryUnit
    {
        private int _energy;

        public int RemovedEnergy { get => MaxEnergy - Energy; }
        public int MaxEnergy;
       
        public int Energy
        {
            get { return _energy; }
            set { _energy = value; }
        }
        public MagicUnit(int health, int maxhealth, string? name, int maxdamage, int mindamage, int energy) : base(health, maxhealth, name, maxdamage, mindamage)
        {
            Energy = energy;
            MaxEnergy = Energy;
        }
    }
}
