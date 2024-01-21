using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Bishop : MagicUnit
    {
        
        
        public Bishop() : base(25, "Колдун")
        {
            EnergyPoints = 60;
            energyLimit = 100;
            Defence = 2;
        }
        public Bishop(int health, string name, int defence, int energy) : base(health, name)
        {
            Defence = defence;
            EnergyPoints = energy;
            energyLimit = energy;
        }

        public void Heal(Unit unit)
        {
            if(EnergyPoints / 2 < unit.MaxHealth - unit.Health)
            {
                while(EnergyPoints > 0)
                {
                    unit.GetHeal(1);
                    EnergyPoints -= 2;
                }
            }
            else
            {
                while (unit.Health < unit.MaxHealth)
                {
                    unit.GetHeal(1);
                    EnergyPoints -= 2;
                }
            }
        }
    }
}
