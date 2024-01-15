namespace StrategyUnits
{
    internal class Bishop : MagicUnit
    {
        public Bishop() : base(15, "Bishop", 1, 4 , 2, 60)//медик
        {
        }
        public void Hellping(Unit unit)
        {
            if (Energy != 0 && unit.Alive != false)
            {
                if (unit.Health != unit.MaxHealth)
                {
                    int a = unit.MaxHealth - unit.Health;
                    if (a * 2 < Energy)
                    {
                        Energy -= a * 2;
                        unit.Health += a;
                        Console.WriteLine($"Hellping...{unit.Name} energy gone {a * 2} energy left {Energy} HP {a}");

                    }
                    else
                    {
                        a = Energy / 2;
                        Energy -= a * 2;
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
