namespace StrategyUnits
{
    internal interface IHealthController
    {
        public double Health { get; protected set; }
        public int MaxHealth { get; protected set; }
        public bool IsAlive { get => Health > 0; }

        public void TakeDamage(double damage);

        public void TakeHeal(double healAmount);
    }
}
