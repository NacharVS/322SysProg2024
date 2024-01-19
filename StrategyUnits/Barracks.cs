namespace StrategyUnits
{
    internal class Barracks
    {
        public Footman CreateRecruit()
        {
            return new Footman(60, 3, 5, 5, "Recruit");
        }
        public Footman CreateFootman()
        {
            return new Footman(90, 5, 10, 5, "Footman");
        }
        public Footman CreateOfficer()
        {
            return new Footman(120, 10, 15, 5, "Officer");
        }
        
        public Berserker CreateBerserker()
        {
            return new Berserker(30, 10, 15, 0, "Berserker");
        }
    }
}
