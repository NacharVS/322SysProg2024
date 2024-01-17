namespace StrategyUnits
{
    internal class Unit
    {
        public delegate void HealthChangedDelegate (int health);

        private int _health;
        private string? _name;

        public int MaxHealth { get; private set; }
        public bool IsAlive { get => _health > 0; }
        public int Defence { get; set; }

        public Unit(int health, string? name, int defence)
        {
            _health = health;
            _name = name;
            MaxHealth = health;
            Defence = defence;
            HealthIncreasedEvent += OnHealthIncrease;
            HealthDecreasedEvent += OnHealthDecrease;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int Health 
        { 
            get => _health; 
            set
            {
                if(value < 0) 
                {
                    _health = 0;
                }
                else
                {
                    if(value > MaxHealth)
                    {
                        _health = MaxHealth;
                    }
                    else
                    {
                        if(value > _health)
                            HealthIncreasedEvent?.Invoke(value);
                        else if (value < _health)
                            HealthDecreasedEvent?.Invoke(value);
                        _health = value;
                    }
                }
            } 
        }

        public int RemovedHealth
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
                Console.WriteLine($"{Name} не может двигатся т.к. умер");
            }
        }

        public virtual void ShowInfo(string additionalText = "")
        {
            Console.WriteLine($"Unit: {_name} Health: {_health}/{MaxHealth}. Защита {Defence}. {additionalText}");
        }

        public void GetDamage(int damage)
        {
            if (Defence > damage)
                Health -= damage - Defence;
        }

        public void GetHeal(int healAmount)
        {
            if (healAmount > 0)
                Health += healAmount;
        }

        public void OnHealthIncrease(int health) 
        {
            Console.WriteLine($"У {Name} здоровье увеличилось до {health}");
        }
        
        public void OnHealthDecrease(int health) 
        {
            Console.WriteLine($"У {Name} здоровье уменьшилось до {health}");
        }

        public event HealthChangedDelegate HealthIncreasedEvent;
        public event HealthChangedDelegate HealthDecreasedEvent;
    }
}
