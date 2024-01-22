using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Berserker : Footman
    {


        private bool IsFrenzy;

        public Berserker(int health, int defence, string? name, int maxdamage, int mindamage) : base(health, defence, name, maxdamage, mindamage)
        {
        }

        public void Frenzy()
        {
            if (Health <= MaxHealth * 0.3)
            {
                IsFrenzy = true;
            }
        }

        public override double CountDamage()
        {
            double damage = base.CountDamage();
            if (IsFrenzy)
                damage *= 3;
            return damage;
        }

        public override void GetHeal(double healAmount)
        {
            if (!IsFrenzy)
                base.GetHeal(healAmount);
        }
    }
}

