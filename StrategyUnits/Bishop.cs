namespace StrategyUnits
{
    internal class Bishop : MagicUnit
    {

        private int _healing;

        public int healing
        {
            get { return _healing; }
            set { _healing = value; }
        }

        public Bishop() : base(45, 50, "Bishop", 3,1, 60)
        {
            _healing = 1;
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
