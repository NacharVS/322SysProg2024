namespace StrategyUnits
{
    internal interface IMagicUnit
    {
        public int Energy { get; set; }

        public int RemovedEnergy => MaxEnergy - Energy;
        public int MaxEnergy {get; set; }
    }
}
