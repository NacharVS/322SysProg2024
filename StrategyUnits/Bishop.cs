using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal class Bishop : Unit,  IHealthController, IArmoredUnit, IHealingSkill
    {
        private int _heal;
        private int mana;
        public int HealPoints { get; set; }
        public int EnergyPoints { get; set; }
        public int EnergyLimit { get; set; }
        public int Armor { get; set ; }
        public int MaxHealth { get ; set; }

        public void Heal(IHealthController unit)
        {
            if (EnergyPoints / 2 < unit.MaxHealth - unit.Health)
            {
                while (EnergyPoints > 0)
                {
                    unit.TakeHeal(1);
                    EnergyPoints -= 2;
                }
            }
            else
            {
                while (unit.Health < unit.MaxHealth)
                {
                    unit.TakeHeal(1);
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

        public void TakeHeal(int healAmount)
        {
            throw new NotImplementedException();
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

