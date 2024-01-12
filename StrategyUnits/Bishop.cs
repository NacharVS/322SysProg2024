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
        public void Hellping(Unit unit)
        {
            if (_energy != 0 && unit.Alive != false)
            {
                if (unit.Health != unit.MaxHealth)
                {
                    int a = unit.MaxHealth - unit.Health;
                    if (a * 2 < _energy)
                    {
                        _energy -= a * 2;
                        unit.Health += a;
                        Console.WriteLine($"Hellping...{unit.Name} energy gone {a * 2} energy left {Energy} HP {a}");

                    }
                    else
                    {
                        a = _energy / 2;
                        _energy -= a * 2;
                        unit.Health += a;
                        Console.WriteLine($"Hellping...{unit.Name} energy gone {a * 2} energy left {Energy} HP {a}");
                    }
                }
                else { Console.WriteLine("Unit Max HP"); }

            }
            else { Console.WriteLine("Cannot be hellping"); }
            

        }

    }
}
