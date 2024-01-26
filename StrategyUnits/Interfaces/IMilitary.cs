namespace StrategyUnits
{
    internal interface IMilitary
    {
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }

        public void Attack(IHealthController unit);
    }
}
