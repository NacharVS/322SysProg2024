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
        public void RestoreEnergy(MagicUnit magicUnit)
        {
            if (energy > 0)
            {
                int energyCount = Math.Min(magicUnit.MaxMana - magicUnit.mana, energy);
                magicUnit.mana += energyCount * 10;
                energy -= energyCount;


            }
        }
    }
}
