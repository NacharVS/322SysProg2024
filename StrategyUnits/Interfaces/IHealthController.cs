namespace StrategyUnits
{
    internal interface IHealthController
    {
        public double Health { get; set; }
        public int MaxHealth { get; set; }
        public bool IsAlive { get => Health > 0; }
        public double RemovedHealth => MaxHealth - Health;

        public void TakeDamage(double damage);

        public void TakeHeal(double healAmount);
    }
}
