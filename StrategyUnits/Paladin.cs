using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace StrategyUnits
{
    internal class Paladin : Unit, IHealthController, IBattleUnit,  ISaintSword, IArmoredUnit
    {
        public int attack { get; set; }
        public int DamageMin { get; set; }
        public int DamageMax { get; set; }
        public int HealPoints { get; set; }
        public int EnergyPoints { get; set; }
        public int EnergyLimit { get; set; }
        public int Armor { get; set; }
        public int MaxHealth { get ; set ; }
        public int Damage { get ; set ; }

        Random random = new Random();

        public Paladin(int health, string? name, int minDamage, int maxDamage, int defence, int energy) : base(health, name)
        {

        }
        public void SaintRow(IHealthController unit)
        {
            InflictDamage(unit);
            EnergyPoints -= 30;
        }
        public void Prayer()
        {
            if (EnergyPoints > 10)
            {
                EnergyPoints -= 10;
                Health += 20;
            }
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
        public void InflictDamage(IHealthController unit)
        {
            unit.TakeDamage(CountDamage());
        }
        public int CountDamage()
        {
            return random.Next(DamageMin, DamageMax);
        }
        public void Refill(int EnergyAmount)
        {
            EnergyPoints += EnergyAmount;
        }

        public void TakeHeal(int healAmount)
        {
            throw new NotImplementedException();
        }

        public void Attack(IHealthController unit)
        {
            throw new NotImplementedException();
        }
    }
}
