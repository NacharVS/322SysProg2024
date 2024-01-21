namespace StrategyUnits
{
    internal class Unit
    {
        public delegate void HealthChangedDelegate(double health);

        private int _currenthealth;
        private string? _name;
        
        public int MaxHealth { get; private set; }
        public bool IsAlive { get => _currenthealth > 0; }
        

        public Unit(int health, string? name) 
        {
            _currenthealth = health;
            _name = name;
            MaxHealth = health;
           
            HealthIncreasedEvent += health => Console.WriteLine($"У {Name} здоровье увеличилось до {health}");
            HealthDecreasedEvent += health => Console.WriteLine($"У {Name} здоровье уменьшилось до {health}");

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
                    if (value > MaxHealth)
                    {
                        _currenthealth = MaxHealth;
                    }
                    else
                    {
                        if (value > _currenthealth)
                            HealthIncreasedEvent?.Invoke(value);
                        else if (value < _currenthealth)
                            HealthDecreasedEvent?.Invoke(value);
                        _currenthealth = value;
                    }
                }
            }
        }
      
        public int Defence { get; set; }
        public double RemovedHealth
        {
            get => MaxHealth - Health;
        }
        public void Move()
        {
            if (IsAlive)
            {
                Console.WriteLine("Is moving");
            }
            else
            {
                Console.WriteLine($"{Name} умер");
            }
        }
        public void GetDamage(int damage)
        {
            if (damage > Defence)
                Health -= damage - Defence;
        }

        public virtual void GetHeal(int healAmount)
        {
            if (healAmount > 0)
                Health += healAmount;
        }


        public virtual void ShowInfo()
        {
            Console.WriteLine($"Unit: {_name} Health: {_currenthealth} MaxHealth: {MaxHealth} Defence:{Defence}");
        }
        public event HealthChangedDelegate HealthIncreasedEvent;

        public event HealthChangedDelegate HealthDecreasedEvent;
    }
    
}
