namespace StrategyUnits
{
    internal class Footman : Unit, IMilitaryUnit, IInflictDamage, IDefence, IRandomDamgeController, IRage
    {
        Random random = new Random();

        public int Defence { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public int damaged { get; set; }


        public Footman(int health, int mindamage, int maxdamage, string? name, int defence) : base(health, name)
        {
            Defence = defence;
            MinDamage = mindamage;
            MaxDamage = maxdamage;
        }



        public int RandomDamage(int MinDamage, int MaxDamage)
        {
            return random.Next(MinDamage - 1, MaxDamage);
        }
        public void InflictDamage(Unit unit)
        {
            TakeDamage(unit, RandomDamage(MinDamage, MaxDamage));
        }


        public void Rage()
        {
            if (Health <= 0)
            {
                Console.WriteLine("Defeated");
                return;
            }

            if (Health < MaxHealth / 2) 
            {
                _damage += _damage / 2; 
            }

            Console.WriteLine("Rage activated");
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Unit: {Name} Health: {Health}  Min demage: {MinDamage} Max demage: {MaxDamage} Defence: {Defence} ");
        }
    }
}

