namespace StrategyUnits
{
    internal class Unit
    {
        public delegate void HealthChangedDelegate(int health);

        private int _health;
        private string? _name;
        public int Defence { get; set; }
        public bool Dead = false;
        public int MaxHealth { get; private set; }

        public Unit(int health, string? name, int defence)
        {
            _health = health;
            _name = name;
            MaxHealth = health;
            Defence = defence;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
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
                    HealthDecreasedEvent?.Invoke(_health);
                    Dead = true;
                }
                else if (MaxHealth < value)
                {
                    _health = MaxHealth;
                    HealthIncreasedEvent?.Invoke(_health);
                }
                else
                {
                    if(_health <= value)
                    {
                        _health = value;
                        HealthIncreasedEvent?.Invoke(_health);
                    }
                    else if (_health > value)
                    {
                        _health = value;
                        HealthDecreasedEvent?.Invoke(_health);
                    }
                    
                }
                
            }
        }

        public void Move()
        {
            Console.WriteLine("Is moving");
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Unit: {_name} Health: {_health}/{MaxHealth} Defence: {Defence}");
        }

        public event HealthChangedDelegate HealthIncreasedEvent;

        public event HealthChangedDelegate HealthDecreasedEvent;
    }
}
