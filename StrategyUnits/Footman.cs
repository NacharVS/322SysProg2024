namespace StrategyUnits
{
    internal class Footman : MiliataryUnit
    {
        public Footman(int health, string? name, int minDamage, int maxDamage, int defence) : base(health, name, minDamage, maxDamage, defence)
        {
        }

        private bool Rage()
        {
            return Health <= MaxHealth * 0.5;
        }

        public override double CountDamage()
        {
            double damage = base.CountDamage();
            if (Rage())
            {
                damage *= 1.5;
            }
            return damage;
        }
    }
}
