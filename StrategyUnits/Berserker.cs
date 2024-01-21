namespace StrategyUnits
{
    internal class Berserker : Footman
    {
        public Berserker(int health, string? name, int minDamage, int maxDamage, int defence) : base(health, name, minDamage, maxDamage, defence)
        {
        }

        public void Frenzy(Unit unit)
        {
            if(unit.Health < unit.Max_healt * 1.3)
            {
                unit.TakeDamage((int)(RandomDamage() * 1));
            }
        }
    }
}
