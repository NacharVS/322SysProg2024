namespace StrategyUnits
{
    internal abstract class Unit : IHealthController
    {
        public delegate void HealthChangedDelegate(double health);
        private double _currentHealth;
        private string? _name;
        public int MaxHealth { get; set; }
        public bool IsAlive => _currentHealth > 0;
        public Unit(int health,string? name)
        {
            _currentHealth = health;
            _name = name;
            MaxHealth = health;

            HealthDecreasedEvent += Hurt1;
            HealthIncreasedEvent += Heal1;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        

        public double Health 
        { 
            get => _currentHealth;

            set 
            { 
                
                if(value < 0)
                {
                    _currentHealth = 0;
                }
                else { 
                    if(value > MaxHealth) 
                    {
                        _currentHealth = MaxHealth;
                    }
                    else
                    {
                        if(value >_currentHealth)
                            HealthIncreasedEvent?.Invoke(value);
                        else if (value < _currentHealth)
                            HealthDecreasedEvent?.Invoke(value);
                        _currentHealth = value;
                    }
                }
            }
        }
        public double RemovedHealth
        {
            get => MaxHealth - Health;
        }

        public void Move()
        {
            if (IsAlive)
                Console.WriteLine("Is moving");
            else
                Console.WriteLine("hahah you died");
        }

        public virtual void ShowInfo(string text = "")
        {
            Console.WriteLine($"Unit: {_name} Health: {_currentHealth}/{MaxHealth}" + text);
        }
     
        public virtual void TakeDamage(double damage)
        {
            if (damage >0)
            Health -= damage;
        }
        public virtual void TakeHeal(double healAmount)
        {
            if (healAmount > 0)
            {
              if(IsAlive)
                Health += healAmount;
              else
                Console.WriteLine("Healing unit is DEAD");
            }
                            
        }
        public event HealthChangedDelegate HealthIncreasedEvent;

        public event HealthChangedDelegate HealthDecreasedEvent;

        public static void Hurt1(double number)
        {
            Console.WriteLine($"Health has decreased. Current health: {number}");
        }

        public static void Heal1(double number)
        {
            Console.WriteLine($"Health has increased. Current health: {number} ");
        }
    }
}
