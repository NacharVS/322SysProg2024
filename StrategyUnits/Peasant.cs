namespace StrategyUnits
{
    internal class Peasant : Unit
    {
        public Peasant() : base(30, 1, "Peasant")
        {
        }

        public Peasant(int health, int defence, string? name) : base(health, defence, name)
        {
        }
    }
}
