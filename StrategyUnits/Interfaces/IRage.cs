namespace StrategyUnits.Interfaces
{
    internal interface IRage : IMilitoryUnit
    {
        public bool RageInfo { get; set; }
        public void Rage();
    }
}
