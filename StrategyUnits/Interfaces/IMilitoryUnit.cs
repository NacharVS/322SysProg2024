namespace StrategyUnits.Interfaces
{
    internal interface IMilitoryUnit :IHealthController
    {
        public int MaxDamage { get; set; }
        public int MinDamage { get; set; }
        public int RandomDamage { get; }
        public void InflictDamage(IHealthController unit);
    }
}
