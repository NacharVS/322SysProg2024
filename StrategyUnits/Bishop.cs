namespace StrategyUnits
{
    internal class Bishop : Unit, IMilitaryUnit, IMagicUnit
    {

        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        
        public int Energy { get; set; }
        public int MaxEnergy { get; set; }

        private Random random = new Random();
        public Bishop(int health, int defence, string? name, int maxdamage, int mindamage, int energy) : base(health, defence, name)
        {
            MinDamage = mindamage;
            MaxDamage = maxdamage;
            Energy = energy;
        }
        public void InflictDamage(IHealController unit)
        {
        double damage = CountDamage();
        unit.GetDamage(damage);
        }

    public virtual double CountDamage()
    {
        return random.Next(MinDamage, MaxDamage);
    }
    public void Healinghealth(IHealController unit)
        {
            double lives = Math.Min(unit.RemovedHealth, Energy / 2);
            unit.GetHeal(lives) ;
            Energy -= Convert.ToInt32(Math.Ceiling(lives *2)) ;
        }

        public void ShowEnergy()
        {
            Console.WriteLine($"Energy: {Energy} ");
        }
    }
}
