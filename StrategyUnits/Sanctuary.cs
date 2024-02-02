using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using StrategyUnits.Useless;

namespace StrategyUnits
{
    internal class Sanctuary
    {
        private int _energyReserve;
        private int _energyCapacity;
        public int EnergyReserve
        {
            get { return _energyReserve; }
            set { _energyReserve = value; }
        }
        public int EnergyCapacity
        {
            get { return _energyCapacity; }
        }
        public Sanctuary()
        {
            _energyReserve = 90;
            _energyCapacity = 350;
        }
        public void refill(MagicUnit magicUnit)
        {
            if (!magicUnit.Alive)
            {
                Console.WriteLine("Персонаж умер. Действие отменено.");
            }
            else
            {
                int energyNeeded = (magicUnit.MaxEnergy - magicUnit.Energy) / 10;

                if (EnergyReserve >= energyNeeded)
                {
                    magicUnit.Energy += energyNeeded * 10;
                    EnergyReserve -= energyNeeded;
                }
                else
                {
                    Console.WriteLine("Недостаточно энергии для восстановления маны.");
                }
            }
        }
    }
}