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
            HealPoints = 1;
            EnergyPoints = 60;
            energyLimit = 100;
        }

        public void Heal(Unit unit)
        {
            if (unit.Alive is false)
            {
                Console.WriteLine(unit.Name + " умер.");
            }
            else
            {
                if(EnergyPoints / 2 < unit.MaxHealth - unit.Health)
            {
                while(EnergyPoints > 0)
                {
                    unit.Health += HealPoints;
                    EnergyPoints -= 2;
                }
            }
            else
            {
                while (unit.Health < unit.MaxHealth)
                {
                    unit.Health += HealPoints;
                        EnergyPoints -= 2;

                    }
                }
            }
            
        }
    }
}
