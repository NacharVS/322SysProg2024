using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal class Bishop : Unit, IMagicUnit, IHealthController, IArmoredUnit, IHealingSkill
    {
        private int _heal;
        private int mana;
        public int HealPoints { get; set; }
        public int EnergyPoints { get; set; }
        public int EnergyLimit { get; set; }
        public int Armor { get; set ; }

        public void Heal(IHealthController unit)
        {
            if (EnergyPoints / 2 < unit.maxHealth - unit.health)
            {
                while (EnergyPoints > 0)
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

        public void TakeDamage(int damage)
        {
            Health -= damage - Armor;
        }

        public void Refill(int EnergyAmount)
        {
            EnergyPoints += EnergyAmount;
        }

        public Bishop(int health, string? name, int minDamage, int maxDamage, int defence, int energy) : base(health, name)
        {
            _heal = 7;
            Armor = defence;
            EnergyPoints = energy;
            EnergyLimit = energy;
        }
    }
}

