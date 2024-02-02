namespace StrategyUnits
{
    internal class Footman : Unit, IMilitaryUnit, IInflictDamage, IDefence, IRandomDamgeController, IRage
    {
        Random random = new Random();
        public Footman(int health, string name, int minDamage, int maxDamage, int defence) : base(health, name)
        {
            Defence = defence;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
        }
        public int Defence { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public int damaged { get; set; }

        public int RandomDamage()
        {
            return random.Next(MinDamage - 1, MaxDamage);
        }
        public void InflictDamage(Unit unit)
        {
            TakeDamage(unit, RandomDamage());
        }
        public void InflictDamage(Unit unit, int procent)
        {
            TakeDamage(unit, RandomDamage() * procent / 100);
        }

        public void Rage(Unit unit)
        {
            if (Health < MaxHealth * 0.50)
            {
                InflictDamage(unit, 50);
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Unit: {Name} Health: {Health}  Min demage: {MinDamage} Max demage: {MaxDamage} Defence: {Defence} ");
        }

    }
}
