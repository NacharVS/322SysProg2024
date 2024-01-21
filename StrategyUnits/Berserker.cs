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
        Random random = new Random();
        public Berserker(int health, string name, int damagemin, int damagemax, int defence)
        {
            DamageMin = damagemin;
            DamageMax = damagemax;
            Health = health;
            Name = name;
            Defence = defence;
        }
        public void Frenzy()
        {
            if(Health < Health * 0.3)
            {
                IsFrenzy = true;
            }
        }
        public override double CountDamage()
        {
            if (IsFrenzy)
            {
                return random.Next(DamageMin, DamageMax) * 5;
            }
            else
            {
                return random.Next(DamageMin, DamageMax);
            }
        }
        public override void GetHeal(double healAmount)
        {
            if (!IsFrenzy)
                base.GetHeal(healAmount);
        }
    }
}
