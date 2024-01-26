namespace StrategyUnits
{
    internal class Footman : Unit, IBattleUnit, IArmoredUnit, IRage
    {
        public int MinDamage { get; set; }
        public int MaxDamage { get ; set; }
        public int Armor { get; set; }
        public bool IsRage => Health <= MaxHealth * 0.5;

        private Random random = new Random();

        public Footman(int health, string? name, int minDamage, int maxDamage, int armor) : base(health, name)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Armor = armor;
        }

        public virtual double CountDamage()
        {

            double damage = random.Next(MinDamage,MaxDamage);
            if(IsRage)
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
            if (Armor < damage)
            {
                Health -= damage - Armor;
            }
            else
                Console.WriteLine("Damage is fully absorbed by unit defense!");
        }
    }
}
