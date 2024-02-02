using StrategyUnits.Interfaces;
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
        public int energyChurch;
        public int EnergyChurch
        {
            get { return energyChurch; }
            set
            {
                if (value < 0)
                {
                    energyChurch = 0;
                }
                else if (MaxEnergyReserve < value)
                {
                    energyChurch = MaxEnergyReserve;
                }
                else
                {
                    energyChurch = value;
                }
            }
        }
        public int MaxEnergyReserve { get; private set; }

        public Church()
        {
            energyChurch = 50;
            MaxEnergyReserve = energyChurch;
            energyReserve = 10;
        }

        public void EnergyRegen(IMagicUnit unit)
        {
            if (unit.Dead)
            {
                Console.WriteLine($"Церковь не может восстановить энергию - персонаж, {unit.Name}, мертв");
            }
            else
            {
                if (EnergyChurch > 0)
                {
                    if (unit.EnergySpent >= EnergyChurch * energyReserve)
                    {
                        unit.Energy += EnergyChurch * energyReserve;
                        EnergyChurch = 0;
                    }
                    else
                    {
                        Restoration = 1;
                        while (Restoration * energyReserve < unit.EnergySpent)
                        {
                            Restoration++;
                        }
                        unit.Energy += Restoration*energyReserve;
                        EnergyChurch -= Restoration;
                    }
                }
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Church Energy reserve: {EnergyChurch}/{MaxEnergyReserve}");
        }
    }
}
