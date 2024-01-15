namespace StrategyUnits
{
    internal class Unit
    {
        public int _health;
        private string? _name;
        public int Max_healt { get; private set; }


        public Unit(int health, string? name)
        {
            _health = health;
            _name = name;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Health 
        {
            get { return _health; } // Отображает при вызове
            set  // Происходит при каком-то изменении
            { 
                if(value < 0)
                {
                    _health = 0;
                }
                else if (Max_healt < value)
                {
                    _health = Max_healt;
                }
                else
                {
                    _health = value;
                }
            }
           
        }

        public void Move()
        {
            Console.WriteLine("Is moving");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Unit: {_name} Health: {_health}");
        }
    }
}
