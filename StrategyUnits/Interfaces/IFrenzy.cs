
namespace StrategyUnits.Interfaces
{
    internal interface IFrenzy : IMilitoryUnit
    {
        public bool FrenzyInfo { get; set; }
        public void Frenzy(IHealthController unit);
    }
}
