namespace StrategyUnits
{
    internal class Unit
    {
        private int _health;
        private string? _name;
        public int _MaxHealth;

        public int MaxHealth { get; private set;  }

        public Unit(int health, int maxhealth, string? name)
        {
            _health = health;
            _name = name;
            _MaxHealth = maxhealth;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Defence { get; set; }

        public int maxhealth
        {
            get { return _MaxHealth; }
            set { _MaxHealth = value; }
        }

        public int Health
        {
            get
            {
                return _health;
            }
            set
            {
                if (value < 0)
                {
                    _health = 0;
                }
                else
                {
                    if (value > maxhealth)
                    {
                        _health = maxhealth;
                    }
                    else
                    {
                        _health = value;
                    }
                }
            }
        }
        public int RemovedHealth { get => MaxHealth - Health; }

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
