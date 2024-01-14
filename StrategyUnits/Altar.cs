

namespace StrategyUnits
{
    internal class Altar : Unit
    {
        public Altar() : base(25 , "Altar")
        {
        
        }
        public void GetEnergy(Bishop bishop)
        {
            while(bishop.Energy < bishop.Maxenergy)
            {
                bishop.Energy++;
            }
            Console.WriteLine($"Set full energy {bishop.Name}");
        }
    }
}
