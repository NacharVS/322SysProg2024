namespace StrategyUnits
{
    internal class Footman : MilitaryUnit
    {
        private int damage;
        

        public Footman() : base(60, "Footman")
        {
            DamageMin = 1;
            DamageMax = 10;
            Defence = 6;
            Random random = new Random();
            damage = random.Next(DamageMin, DamageMax);
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"{Name} damage: {damage}. {Health}/{MaxHealth}");
        }

    }
}
