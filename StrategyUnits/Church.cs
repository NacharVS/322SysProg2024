using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Church
    {
        public int EnergyReserve { get; private set; }

        public Church()
        {
            EnergyReserve = 600;
        }

        public void EnergyRegen(MagicUnit magicUnit)
        {
            if (EnergyReserve > 0)
            {
                if (magicUnit.EnergySpent >= EnergyReserve)
                {
                    magicUnit.Energy += EnergyReserve;
                    EnergyReserve = 0;
                }
                else
                {
                    magicUnit.Energy += magicUnit.EnergySpent;
                    EnergyReserve -= magicUnit.EnergySpent;
                }
            }
        }
    }
}
