using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Zelot : Unit, IMagicUnit, IArmoredUnit, IHealthControl, IBattleUnit, ICheckArmorOfFaithSkill
    {
        private bool ArmorOfFaith;
        public Zelot(int _health, string name, int damagemin, int damagemax, int defence, int energy) : base(_health, name)
        {
            DamageMin = damagemin;
            DamageMax = damagemax;
            Armor = defence;
            EnergyPoints = energy;
            EnergyLimit = energy;
        }

        public int HealPoints { get; set; }
        public int EnergyPoints { get; set; }
        public int EnergyLimit { get; set; }
        public int Armor { get; set; }
        public int attack { get; set; }
        public int DamageMin { get; set; }
        public int DamageMax { get; set; }

        Random random = new Random();
        public double CountDamage()
        {
            return random.Next(DamageMin, DamageMax);
        }

        public void InflictDamage(IHealthControl unit)
        {
            unit.TakeDamage(CountDamage());
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

        public void CheckArmorOfFaith(double _health)
        {
            if (_health > maxHealth * 0.3 && ArmorOfFaith)
            {
                ArmorOfFaith = false;
                Armor = Armor - Armor / 2;
            }
            else if (_health <= maxHealth * 0.3 && !ArmorOfFaith)
            {
                ArmorOfFaith = true;
                Armor = Armor * 2;
            }
        }
    }
}
