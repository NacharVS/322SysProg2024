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
                int energy = Math.Min(EnergyCapacity*10, magicUnit.RemovedEnergy);
                magicUnit.Energy += energy;
                EnergyCapacity -= Convert.ToInt32(Math.Ceiling(energy/10d));
                Console.WriteLine($"Fountain is restored {magicUnit.Name} {energy} energy.");
            }
            else
            {
                Console.WriteLine("Fountain is empty!");
            }
        }
        public Bishop CreateBishop()
        {
            return new Bishop(60, 0, 0, 0, 60, "Bishop");
        }
        public Paladin CreatePaladin()
        {
            return new Paladin(50, 5, 10, 5, 70, "Paladin");
        }
        public Zealot CreateZealot()
        {
            return new Zealot(50, 10, 15, 5, 20, "Zealot");
        }
    }
}
