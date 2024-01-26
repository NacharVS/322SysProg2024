namespace StrategyUnits
{
    internal class Barracks
    {
        public Footman CreateRecruit()
        {
            return new Footman(60,"Recruit", 3, 7, 3);
        }
        public Footman CreateFootman()
        {
            return new Footman(90, "Footman", 5, 10, 5);
        }
        public Footman CreateOfficer()
        {
            return new Footman(120, "Officer", 10, 15, 5);
        }
        
        public Berserker CreateBerserker()
        {
            return new Berserker(30, "Berserker", 20, 30, 5);
        }
    }
}
