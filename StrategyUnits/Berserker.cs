using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Berserker : Unit, IMilitary, IRageable, IFrenzy
    {
        public Berserker(int health, string? name, int minDamage, int maxDamage) : base(health, name)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
        }

        public bool IsFrenzy { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public bool IsRage => Health <= MaxHealth * 0.5;

        private Random random = new Random();

        public void Frenzy() 
        {
            if(Health <= MaxHealth * 0.3)
            {
                IsFrenzy = true;
            }
        }

        public double CountDamage()
        {
            double damage = random.Next(MinDamage,MaxDamage);
            if (IsRage)
            {
                damage *= 1.5;
            }
            if (IsFrenzy)
                damage *= 3;
            return damage;
        }

        public override void TakeHeal(double healAmount)
        {
            if(!IsFrenzy)
                base.TakeHeal(healAmount);
        }

        public void Attack(IHealthController unit)
        {
            unit.TakeDamage(CountDamage());
        }
    }
}
