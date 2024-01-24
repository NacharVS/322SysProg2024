namespace StrategyUnits
{
    internal interface IHealthController
    {
        public int Health { get; set; }

        public void TakeDamage(int damage);

        public void TakeHeal(int healAmount);
    }
}
