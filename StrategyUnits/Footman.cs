using System.Runtime.Intrinsics.Arm;

namespace StrategyUnits
{
    internal class Footman : Unit, IMilitary, IArmored, IRageable
    {
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }

        public int Armor { get; set; }

        private Random random = new Random();

        public Footman(int health, string? name, int minDamage, int maxDamage, int armor) : base(health, name)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Armor = armor;
        }

        public bool IsRage => Health <= MaxHealth * 0.5;

        public double CountDamage()
        {
            double damage = random.Next(MinDamage,MaxDamage);
            if (IsRage)
            {
                damage *= 1.5;
            }
            return damage;
        }

        public void Attack(IHealthController unit)
        {
            unit.TakeDamage(CountDamage());
        }

        public override void TakeDamage(double damage)
        {
            base.TakeDamage(damage);
        }
    }
}
