namespace StrategyUnits
{
    internal interface IHealthController
    {
        public int Health { get; set; }
        public int MaxHealth { get; protected set; }
        public bool IsAlive { get => Health > 0; }
        public void TakeDamage(int damage);
        public void TakeHeal(int healAmount);
    }
}
