namespace StrategyUnits
{
    internal class Hut
    {
        public Peasant CreatePeasant()
        {
            return new Peasant(30, 99, "Peasant");
        }
    }
}
