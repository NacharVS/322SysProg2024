namespace StrategyUnits
{
    internal class Footman : Unit, IMilitary, IArmored 
    {
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }

        private Random random = new Random();

        public Footman(int health, string? name, int minDamage, int maxDamage, int defence) : base(health, name)
        {
        }

        private bool Rage()
        {
            return Health <= MaxHealth * 0.5;
        }

        public double CountDamage()
        {
            double damage = random.Next(MinDamage,MaxDamage);
            if (Rage())
            {
                damage *= 1.5;
            }
            return damage;
        }

        public void Attack(IHealthController unit)
        {
            throw new NotImplementedException();
        }
    }
}
