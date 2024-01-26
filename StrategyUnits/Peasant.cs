namespace StrategyUnits
{
    internal class Peasant : Unit,  IBattleUnit
    {
        private Random random = new Random();

        public Peasant(int health, string? name, int minDamage, int maxDamage) : base(health, name)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
        }

        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }

        public void Attack(IHealthController unit)
        {
            unit.TakeDamage(CountDamage());
        }

        public double CountDamage()
        {
            double damage = random.Next(MinDamage, MaxDamage);
            return damage;
        }
    }
}
