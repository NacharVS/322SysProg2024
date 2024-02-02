namespace StrategyUnits.Interfaces
{
    internal interface IHealthController
    {
        public bool Dead { get; set; }
        public int Health { get; set; }
        public int Defence { get; set; }
        public string? Name { get; set; }
        public int MaxHealth { get; set; }

        public void TakeDamage(int damage);

        public void TakeHeal(int healAmount);
    }
}
