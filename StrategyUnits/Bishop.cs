using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Bishop : MagicUnit
    {
        public Bishop(int health, string? name, int minDamage, int maxDamage, int defence) : base(health, name, minDamage, maxDamage, defence)
        {
        }

        public delegate void HealDelegate(int Mana, int health, string BishopName, string UnitName);   
        public void Heal(Unit unit)
        {
            if (unit.Alive is false)
            {
                Console.WriteLine(unit.Name + " умер.");
            }
            else
            {
                while (Energy >=2 && unit.Health != unit.MaxHealth)
            {
                    unit.Health += 1;
                    Energy -= 2;
            }
                HealEvent?.Invoke(Energy, unit.Health, Name, unit.Name);
           
            }
            
        }
        public event HealDelegate HealEvent;
    }
}
