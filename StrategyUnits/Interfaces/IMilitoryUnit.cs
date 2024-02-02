namespace StrategyUnits.Interfaces
{
    internal interface IMilitoryUnit
    {
        public int MaxDamage { get; set; }
        public int MinDamage { get; set; }
        public int RandomDamage { get; }
        public void InflictDamage(IHealthController unit);
    }
}
