namespace StrategyUnits
{
    internal interface IMagic
    {
        public int Mana { get; set; }

        public int RemovedMana => MaxMana - Mana;

        public int MaxMana { get; set; }
    }
}
