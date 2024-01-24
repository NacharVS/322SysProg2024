namespace StrategyUnits
{
    internal abstract class Unit : IHealthController
    {
        public delegate void HealthChangedDelegate (double health);

        private double _health;
        private string? _name;

        public int MaxHealth { get; set; }
        public bool IsAlive { get => _health > 0; }

        public Unit(int health, string? name)
        {
            _health = health;
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

        public double Health 
        { 
            get => _health; 
            protected set
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

        public double RemovedHealth
        {
            get => MaxHealth - Health;
        }
        double IHealthController.Health { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
            Console.WriteLine($"Unit: {_name} Health: {_health}/{MaxHealth}. {additionalText}");
        }

        public void TakeDamage(double damage)
        {
            Health -= damage;
        }

        public virtual void TakeHeal(double healAmount)
        {
            if (healAmount > 0)
                Health += healAmount;
        }

        public event HealthChangedDelegate HealthIncreasedEvent;
        public event HealthChangedDelegate HealthDecreasedEvent;
    }
}
