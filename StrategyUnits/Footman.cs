namespace StrategyUnits
{
    internal class Footman : Unit, IMilitaryUnit, IDefenced, IRage
    {
        private int _damage;

        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public int Defence { get; set; }

        private Random random = new Random();

        public Footman(int health, int defence, string? name, int maxdamage, int mindamage) : base(health,  name)
        {
            MaxDamage = maxdamage;
            MinDamage = mindamage;
            Defence = defence;
        }

        public bool IsRage => Health <= MaxHealth * 0.5;
        public double CountDamage()
        {
            double damage = random.Next(MinDamage, MaxDamage);
            if (IsRage)
            {
                damage *= 1.5;
            }
            return damage;
        }
        public void InflictDamage(IHealController unit)
        {
            unit.GetDamage(CountDamage());
        }

        public override void GetDamage(double damage)
        {
            base.GetDamage(damage);
        }
    }
}

