namespace StrategyUnits.Interfaces
{
    internal interface ISacredBlow : IMagicUnit
    {
        public int EnergyCost { get; set; }
        public void SacredBlow(IHealthController unit);
    }
}
