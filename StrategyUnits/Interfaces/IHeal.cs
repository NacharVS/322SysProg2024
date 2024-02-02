namespace StrategyUnits.Interfaces
{
    internal interface IHeal : IMagicUnit
    {
        public int EnergyCost { get; set; }
        public void Healing(IHealthController unit);
    }
}
