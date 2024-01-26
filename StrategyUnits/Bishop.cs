using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Bishop : Unit, IMagicUnit, IHealthControl, IArmoredUnit, IHealingSkill
    {
        public int HealPoints { get; set; }
        public int EnergyPoints { get; set; }
        public int EnergyLimit { get; set; }
        public int Armor { get; set; }

        public Bishop() : base(25, "Колдун")
        {
            EnergyPoints = 60;
            EnergyLimit = 100;
             Armor = 2;
        }
        public Bishop(int health, string name, int defence, int energy) : base(health, name)
        {
            Armor = defence;
            EnergyPoints = energy;
            EnergyLimit = energy;
        }


        public void Heal(IHealthControl unit)
        {
            if(EnergyPoints / 2 < unit.maxHealth - unit.health)
            {
                while(EnergyPoints > 0)
                {
                    unit.GetHeal(1);
                    EnergyPoints -= 2;
                }
            }
            else
            {
                while (unit.health < unit.maxHealth)
                {
                    unit.GetHeal(1);
                    EnergyPoints -= 2;
                }
            }
        }

        public void Refill(int EnergyAmount)
        {
            EnergyPoints += EnergyAmount;
        }

        public void TakeDamage(double Damage)
        {
            if (Armor > Damage)
            {
                Armor -= (int)Damage;
            }
            else
            {
                Damage -= Armor;
                Armor = 0;
                health -= Damage;
            }
        }
    }
}
