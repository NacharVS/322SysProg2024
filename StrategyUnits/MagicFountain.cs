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

        public void RestoreEnergy(IMagicUnit magicUnit)
        {
            if (EnergyCapacity > 0)
            {
                int energy = Math.Min(EnergyCapacity*10, magicUnit.RemovedEnergy);
                magicUnit.Energy += energy;
                EnergyCapacity -= Convert.ToInt32(Math.Ceiling(energy/10d));
                Console.WriteLine($"Fountain is restored {energy} energy.");
            }
            else
            {
                Console.WriteLine("Fountain is empty!");
            }
        }
        public Bishop CreateBishop()
        {
            return new Bishop(60, "Bishop", 0, 0, 60);
        }
        public Paladin CreatePaladin()
        {
            return new Paladin(50, "Paladin", 5, 10, 70, 5);
        }
        public Zealot CreateZealot()
        {
            return new Zealot(50, "Zealot", 10, 15, 20, 5);
        }
    }
}
