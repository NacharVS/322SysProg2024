namespace StrategyUnits
{
    internal class Unit
    {
        private int _currenthealth;
        private string? _name;
        public int _MaxHealth;
        private int _energy;

        public int MaxHealth { get; private set; }

        public Unit(int health, int maxhealth, string? name)
        {
            _currenthealth = health;
            _name = name;
            _MaxHealth = maxhealth; 
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int maxhealth
        {
            get { return _MaxHealth; }
            set { _MaxHealth = value; }
        }
        public int Health 
        { 
            get
            {
                return _currenthealth;
            }
            set
            {
                if (value < 0)
                {
                    _currenthealth = 0;
                }
                else
                {
                    if (value > maxhealth)
                    {
                        _currenthealth = maxhealth;
                    }
                    else
                    {
                        _currenthealth = value;
                    }
                }
            }
        }

        public void Move()
        {
            Console.WriteLine("Is moving");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Unit: {_name} Health: {_currenthealth}");
        }
    }
}
