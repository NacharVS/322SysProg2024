using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace StrategyUnits
{
    internal class Zelot : Unit, IArmoredUnit, IHealthController, IBattleUnit, ICheckArmorOfFaithSkill
    {
        public Zelot(int health, string? name, int minDamage, int maxDamage, int defence, int energy) : base(health, name)
        {
            DamageMin = minDamage;
            DamageMax = maxDamage;
            Armor = defence;
            EnergyLimit = energy;
        }

        public int HealPoints { get; set; }
        public int EnergyPoints { get; set; }
        public int EnergyLimit { get; set; }
        public int Armor { get; set; }
        public int attack { get; set; }
        public int DamageMin { get; set; }
        public int DamageMax { get; set; }
        public int MaxHealth { get; set; }
        public int Damage { get; set; }

        Random random = new Random();
        public void Attack(IHealthController unit)
        {
            throw new NotImplementedException();
        }
        public void Refill(int EnergyAmount)
        {
            EnergyPoints += EnergyAmount;
        }
        public void TakeDamage(int damage)
        {
            if (Armor > Damage)
            {
                Armor -= (int)Damage;
            }
            else
            {
                Damage -= Armor;
                Armor = 0;
                Health -= Damage;
            }
        }

        public void TakeHeal(int healAmount)
        {
            throw new NotImplementedException();
        }



        public double CountDamage()
        {
            return random.Next(DamageMin, DamageMax);
        }

        public void InflictDamage(IHealthController unit)
        {
            unit.TakeDamage((int)CountDamage());
        }

        private void CheckArmorOfFaith(double health)
        {
            if (health <= MaxHealth*0.3)
            {

                Armor += Armor;
            }
            else if (health > MaxHealth * 0.3)
            {

                Armor -= Armor / 2;
            }

        }

    }
}

