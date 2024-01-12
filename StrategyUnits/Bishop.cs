namespace StrategyUnits
{
    internal class Bishop : Unit
    {
        private int _heal;
        private int _energy;
        public int Heal
        {
            get { return _heal; }
            set { _heal = value; }
        }
        public int Energy
        {
            get { return _energy; }
            set { _energy = value; }
        }
        public Bishop() : base(60, "Bishop")
        {
            _heal= 7;
            _energy = 5;
        }
        public void HealUnit(Unit unit)
        {
            if (IsAlive)
            {
                if (Energy > 0)
                {
                    unit.Health += _heal;
                    Energy -= 1;
                }
                else
                {
                    Console.WriteLine("Недостаточно энергии");
                }
            }
            else
                Console.WriteLine("This unit is fucked");
        }
        public override void ShowInfo(string text="")
        {

            base.ShowInfo($"Energy: {_energy}");
            
        }
    }
}
