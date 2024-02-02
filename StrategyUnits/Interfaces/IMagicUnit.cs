namespace StrategyUnits.Interfaces
{
    internal interface IMagicUnit : IHealthController
    {
        public int MaxEnergy { get; set; }
        public int EnergySpent { get; }
        public int Energy { get; set; }
    }
}
