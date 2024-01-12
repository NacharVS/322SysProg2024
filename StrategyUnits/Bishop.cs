namespace StrategyUnits
{
    internal class Bishop : Unit
    {
        private int _heal;
        public int Heal
        {
            get { return _heal; }
            set { _heal = value; }
        }
        public Bishop() : base(60, "Bishop")
        {
            _heal= 7;
        }
        public void HealUnit(Unit unit)
        {
            unit.Health += _heal;
        }
    }
}
