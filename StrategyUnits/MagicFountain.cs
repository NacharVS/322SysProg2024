using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MagicFountain
    {
        public int EnergyCapacity {get; private set;}

        public MagicFountain()
        {
            EnergyCapacity = 1000;
        }

        public void RestoreEnergy(MagicUnit magicUnit)
        {
            if (EnergyCapacity > 0)
            {
                int mana = Math.Min(magicUnit.RemovedMana, EnergyCapacity * 10);
                magicUnit.Mana += mana;
                EnergyCapacity -= Convert.ToInt32(Math.Ceiling(mana / 10d));
            }
            else
            {
                Console.WriteLine("В фонтане нет энергии");
            }
        }
    }
}
