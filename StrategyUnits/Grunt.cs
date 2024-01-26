namespace StrategyUnits
{
    internal class Grunt : Unit,IHealthController, IBattleUnit, IArmoredUnit
    {
        private Random random = new Random();
        public Grunt(int health, string? name, int minDamage, int maxDamage, int armor) : base(health, name)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Armor = armor;
        }

        public int Armor { get ; set ; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }

        public void Attack(IHealthController unit)
        {
            unit.TakeDamage(random.Next(MinDamage, MaxDamage));
        }

        public double CountDamage()
        {
            double damage = random.Next(MinDamage, MaxDamage);
            return damage;
        }
        public override void TakeDamage(double damage)
        {
            if (Armor < damage)
            {
                Health -= damage - Armor;
            }
            else
                Console.WriteLine("Damage is fully absorbed by unit defense!");
        }
    }
}
