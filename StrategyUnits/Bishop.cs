namespace StrategyUnits
{
    internal class Bishop : MagicUnit
    {
        
        
        public Bishop() : base(60, "Bishop")
        {
            _energy = 60;
            MaxEnergy = Energy;
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
                int lives = Math.Min(unit.RemovedHealth, _energy/2);
                    unit.Health += lives;
                    Energy -= lives *2;
                }
                else
                {
                    Console.WriteLine("Недостаточно энергии");
                }
        }
        public override void ShowInfo(string text="")
        {

            base.ShowInfo($"Energy: {_energy}");
            
        }
    }
}
