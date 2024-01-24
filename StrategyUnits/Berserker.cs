using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Berserker : Unit, IMilitaryUnit, IFrenzy, IDefenced, IRage
    {


        private bool IsFrenzy;

        public Berserker(int health, int defence, string? name, int maxdamage, int mindamage) : base(health, defence, name)
        {
            MaxDamage = maxdamage;
            MinDamage = mindamage;
        }

        public bool IsFrenzy { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public bool IsRage => Health <= MaxHealth * 0.5;

        private Random random = new Random();
        public void Frenzy()
        {
            if (Health <= MaxHealth * 0.3)
            {
                IsFrenzy = true;
            }
        }

        public double CountDamage()
        {
            double damage = random.Next(MinDamage, MaxDamage);
            if (IsRage)
            {
                damage *= 1.5;
            }
            if (IsFrenzy)
                damage *= 3;
            return damage;
        }
        public override void GetDamage(double damage)
        {
            if (damage - Defence > 0)
            {
                base.GetDamage(damage - Defence);
            }
        }

        public override void GetHeal(double healAmount)
        {
            if (!IsFrenzy)
                base.GetHeal(healAmount);
        }

        public void InflictDamage(IHealController unit)
        {
            unit.GetDamage(CountDamage());
        }
    }
}

