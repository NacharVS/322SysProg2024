namespace StrategyUnits
{
    internal class Unit
    {
        public int _health;
        private string? _name;
        private int _defense;
        public int Max_healt { get; private set; }


        public Unit(int health, string? name, int defense)
        {
            _health = health;
            _name = name;
            _defense = defense;
        }

        public int Defense
        {
            get { return _defense; }
            set { _defense = value; }
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

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Unit: {_name} Health: {_health}");
        }
    }
}
