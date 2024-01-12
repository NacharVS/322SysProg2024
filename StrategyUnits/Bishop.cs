namespace StrategyUnits
{
    internal class Bishop : Unit
    {
        private int _energy;
        public int Energy
        {
            get
            {
                return _energy;
            }
            set
            {
                if (value < 0)
                {
                    _energy = 0;
                }
                else
                {
                    if (value > MaxHealth)
                    {
                        _energy = MaxHealth;
                    }
                    else
                    {
                        _energy = value;
                    }
                }
            }
        }
        public int MaxEnergy;
        
        public Bishop() : base(60, "Bishop")
        {
            _energy = 60;
            MaxEnergy = Energy;
        }
        public void HealUnit(Unit unit)
        {
            if (!IsAlive)
            {
                Console.WriteLine("This unit is fucked");
                return; 
            }
            if (!unit.IsAlive)
            {
                Console.WriteLine("Healing unit is fucked");
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
