using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Berserker : Unit, IBattleUnit, IArmoredUnit, IFrenzy, IRage
    {

        public bool IsFrenzy { get; set; }
        public int Armor { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public bool IsRage => Health <= MaxHealth * 0.5;
        private Random random = new Random();

        public Berserker(int health, string? name, int minDamage, int maxDamage, int armor) : base(health, name)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Armor = armor;
        }

        public void Frenzy()
        {
            Console.WriteLine($"{Name} is using Frenzy!");
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
            {
                damage *= 3;
            }
            return damage;
        }
        public override void TakeHeal(double healAmount)
        {
            if (IsFrenzy)
                Console.WriteLine($"{Name} is in Frenzy!");
            else
            base.TakeHeal(healAmount);
        }

        public void Attack(IHealthController unit)
        {
            unit.TakeDamage(CountDamage());
        }


    }
}
