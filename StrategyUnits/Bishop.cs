namespace StrategyUnits
{
    internal class Bishop : MagicUnit
    {
        
        public Bishop(int health, int mindamage, int maxdamage, int defense, int energy, string? name) : base(health, mindamage, maxdamage, defense, energy, name)
        {
        }

        public void HealUnit(Unit unit)
        {
            if (!IsAlive)
            {
                Console.WriteLine("This unit is DEAD");
                return; 
            }
            if (!unit.IsAlive)
            {
                Console.WriteLine("Healing unit is DEAD");
                return;
            }
            if (_energy >= 2)
                {
                double lives = Math.Min(unit.RemovedHealth, _energy/2);
                    unit.GetHeal(lives);
                    Energy -= Convert.ToInt32(Math.Ceiling(lives *2));
                }
                else
                {
                    Console.WriteLine("Not enough energy!");
                }
        }
        
    }
}
