namespace StrategyUnits
{
    internal class Footman : MilitaryUnit
    {
        public Footman(int health, string name, int minDamage, int maxDamage, int defence) : base(health, name, minDamage, maxDamage, defence)
        {
        }
        public void Rage(Unit unit)
        {
            if (Health < MaxHealth * 0.50)
            {
                InflictDamage(unit , 50);
            }
        }
    }
}
