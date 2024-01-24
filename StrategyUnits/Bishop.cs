namespace StrategyUnits
{
    internal class Bishop : MagicUnit
    {



        public Bishop(int health, int defence, string? name, int maxdamage, int mindamage, int energy) : base(health, defence, name, maxdamage, mindamage, energy)
        {
        }

        public void Healinghealth(Unit unit)
        {
            double lives = Math.Min(unit.RemovedHealth, Energy / 2);
            unit.GetHeal(lives) ;
            Energy -= Convert.ToInt32(Math.Ceiling(lives *2)) ;
        }

        public void ShowEnergy()
        {
            Console.WriteLine($"Energy: {Energy} ");
        }
    }
}
