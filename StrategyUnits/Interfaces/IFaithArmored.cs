namespace StrategyUnits
{
    internal interface IFaithArmored
    {
        public bool IsArmorOfFaith { get; set; }

        public void CheckArmorOfFaith(double health);
    }
}
