using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MagicFountain
    {
        public int EnergyCapacity { get; private set; }

        public MagicFountain()
        {
            EnergyCapacity = 1000;
        }

        public void RestoreEnergy(MagicUnit magicUnit)
        {
            if (EnergyCapacity > 0)
            {
                int energy = Math.Min(EnergyCapacity, magicUnit.RemovedEnergy);
                magicUnit.Energy += energy;
                EnergyCapacity -= energy;
            }
        }
    }
}
