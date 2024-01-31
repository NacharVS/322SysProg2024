using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace StrategyUnits
{
    internal class Berserker: Unit, IHealthController,IBattleUnit,IArmoredUnit, IRage
    {
        public Berserker(int health, string? name, int minDamage, int maxDamage, int defence) : base(health, name)
        {
            DamageMin = damagemin;
            DamageMax = damagemax;
            Name = name;
            Armor = defence;
        }

        private bool IsFrenzy;
        Random random = new Random();


       
        public int attack { get; set; }
        public int DamageMin { get; set; }
        public int DamageMax { get; set; }
        public bool IsRage { get; set; }
        public int Damage { get; set; }
        public int Armor { get; set; }

        public void Frenzy()
        {
            if (Health <= MaxHealth * 0.3)
            {
                IsFrenzy = true;
            }
        }

        public double CountDamage()
        {
            if (IsFrenzy && IsRage)
            {
                return random.Next(DamageMin, DamageMax) * 5 * 1.5;
            }
            else if (IsFrenzy)
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

        public override void GetHeal(int healAmount)
        {
            if (!IsFrenzy)
                base.GetHeal(healAmount);
        }

        public void TakeDamage(int damage)
        {
            throw new NotImplementedException();
        }

        public void TakeHeal(int healAmount)
        {
            throw new NotImplementedException();
        }

        public void Attack(IHealthController unit)
        {
            throw new NotImplementedException();
        }
        public void InflictDamage(IHealthController unit)
        {
            unit.TakeDamage(CountDamage());
        }
        public void Rage()
        {
            IsRage = true;
        }
    }
}

