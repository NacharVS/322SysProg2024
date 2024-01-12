namespace StrategyUnits
{
    internal class Bishop : Unit
    {
        private int _energy {  get;  set; }

        public int Energy { get { return _energy; } }
        public Bishop() : base(15, "Bishop")
        {
            _energy = 60;
        }
        public void Helping(Unit unit)
        {
            if(_energy != 0 && unit.Alive != false)
            {
                if (unit.Health != unit.MaxHealth)
                {
                    int a = unit.MaxHealth - unit.Health;
                    if (a * 2 < _energy)
                    {
                        _energy -= a * 2;
                        unit.Health += a;
                    }
                    else
                    {
                        a = _energy / 2;
                        _energy -= a * 2;
                        unit.Health += a;
                    }
                }
            }

        }
        public void InfoEnergy()
        {
            Console.WriteLine($"Max energy {_energy}");
        }
    }
}
