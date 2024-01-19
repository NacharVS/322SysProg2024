using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Berserker : Footman
    {
        public Berserker(int health, int mindamage, int maxdamage, int defense, string? name) : base(health, mindamage, maxdamage, defense, name)
        {
        }
        private bool LowHP;

        public void Frenzy()
        {
            double damage = CountDamage();
            if (Health <= MaxHealth * 0.3)
            {
                LowHP = true;
            }
        }
        public override double CountDamage()
        {
            double damage = base.CountDamage();
            if (LowHP)
                damage *= 3;
            return damage;
        }
        public override void GetHeal(double healAmount)
        {
            if (LowHP)
                Console.WriteLine("Я конченный бегите");
            else
            base.GetHeal(healAmount);
        }
    }
}
