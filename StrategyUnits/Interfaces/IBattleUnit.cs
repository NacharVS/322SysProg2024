namespace StrategyUnits
{
    internal interface IBattleUnit
    {
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public void Attack(IHealthController unit);
        public double CountDamage();
        
    }
}
