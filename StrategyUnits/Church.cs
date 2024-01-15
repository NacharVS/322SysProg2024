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
        public int energyReserve;
        public int Restoration;
        public int EnergyReserve
        {
            get { return energyReserve; }
            set
            {
                if (value < 0)
                {
                    energyReserve = 0;
                }
                else if (MaxEnergyReserve < value)
                {
                    energyReserve = MaxEnergyReserve;
                }
                else
                {
                    energyReserve = value;
                }
            }
        }
        public int MaxEnergyReserve { get; private set; }

        public Church()
        {
            energyReserve = 600;
            MaxEnergyReserve = energyReserve;
        }

        public void EnergyRegen(MagicUnit magicUnit)
        {
            if (magicUnit.Dead)
            {
                Console.WriteLine("Церковь не может восстановить энергию - персонаж мертв");
            }
            else
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
                        Restoration = magicUnit.EnergySpent;
                        magicUnit.Energy += Restoration;
                        EnergyReserve -= Restoration;
                    }
                }
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Church Energy reserve: {EnergyReserve}/{MaxEnergyReserve}");
        }
    }
}
