using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Berserker : Unit, IHealthControl, IArmoredUnit, IBattleUnit, IRage
    {
        private bool IsFrenzy;
        Random random = new Random();

        public int Armor { get; set; }
        public int attack  { get; set; }
        public int DamageMin  { get; set; }
        public int DamageMax  { get; set; }
        public double Damage  { get; set; }
        public bool IsRage { get; set; }

        public Berserker(int health, string name, int damagemin, int damagemax, int defence) : base(health, name)
        {
            DamageMin = damagemin;
            DamageMax = damagemax;
            Name = name;
            Armor = defence;
        }

        public void InflictDamage(IHealthControl unit)
        {
            unit.TakeDamage(CountDamage());
        }

        public void Rage()
        {
            IsRage = true;
        }

        public double CountDamage()
        {
            if (IsFrenzy && IsRage)
            {
                return random.Next(DamageMin, DamageMax) * 5 * 1.5;
            }
            else if(IsFrenzy)
            {
                return random.Next(DamageMin, DamageMax) * 5;
            }
            else if (IsRage)
            {
                return random.Next(DamageMin, DamageMax) * 1.5;
            }
            else
            {
                return random.Next(DamageMin, DamageMax);
            }
        }

        public void Frenzy()
        {
            if (health < health * 0.3)
            {
                IsFrenzy = true;
            }
        }
        
        public override void GetHeal(double healAmount)
        {
            if (!IsFrenzy)
                base.GetHeal(healAmount);
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
