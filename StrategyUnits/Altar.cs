using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Altar
    {
        public int energy { get; set; }
        public Altar(int intialEnergy)
        {
            energy = intialEnergy;
        }
        public void RestoreEnergy(Bishop bishop)
        {
            if (energy > 0)
            {
                int energyCount = Math.Min(bishop.MaxEnergy - bishop.energy, energy);
                bishop.energy += energyCount;
                energy -= energyCount;
            }
        }
    }
}
