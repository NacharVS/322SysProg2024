using System;
using System.Security.Cryptography;

namespace StrategyUnits
{
    internal class Footman : MilitaryUnit
    {
        private int damage;
        public Footman(int health, string? name, int damagemin, int damagemax, int defence) : base(health, name)
        {
            DamageMin = damagemin;
            DamageMax = damagemax;
            Defence = defence;
        }

        public Footman() : base(60, "Footman")
        {
            DamageMin = 1;
            DamageMax = 10;
            Defence = 6;
            Random random = new Random();
            damage = random.Next(DamageMin, DamageMax);
        }
        public void Rage(Unit unit)
        {
            unit.TakeDamage(CountDamage() * 1.5);
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"{Name} damage: {damage}. {Health}/{MaxHealth}");
        }

    }
}
