using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Palladin : Unit, IHealthControl, IBattleUnit, IMagicUnit, ISaintSword, IArmoredUnit
    {
        public int attack { get; set; }
        public int DamageMin { get; set; }
        public int DamageMax { get; set; }
        public int HealPoints { get; set; }
        public int EnergyPoints { get; set; }
        public int EnergyLimit { get; set; }
        public int Armor { get; set; }

        Random random = new Random();

        public Palladin(int health, string name) : base(health, name)
        {
            DamageMin = 1;
            DamageMax = 8;
            EnergyPoints = 60;
            EnergyLimit = 100;
            Armor = 4;
        }
        public Palladin(int health, string name, int damagemin, int damagemax, int defence, int energy) : base(health, name)
        {
            DamageMin = damagemin;
            DamageMax = damagemax;
            Armor = defence;
            EnergyPoints = energy;
            EnergyLimit = energy;
        }
        public void SaintSword(IHealthControl unit)
        {
            InflictDamage(unit);
            EnergyPoints -= 30;
            
        }
        public void Prayer()
        {
            if(EnergyPoints > 10)
            {
                EnergyPoints -= 10;
                health += 20;
            }
        }
        public void InflictDamage(IHealthControl unit)
        {
            unit.TakeDamage(CountDamage());
        }
        public double CountDamage()
        {
            return random.Next(DamageMin, DamageMax);
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
