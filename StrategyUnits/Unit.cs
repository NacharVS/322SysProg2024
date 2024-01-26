namespace StrategyUnits
{
    internal class Unit : IHealthController
    {
        public delegate void HealthChangedDelegate(int health);

        private int _health;
        public int Defence { get; set; }
        public bool Dead { get; set; }
        public int MaxHealth { get; private set; }
        public string? Name {  get; set; }
        public Unit(int health, string? name, int defence)
        {
            _health = health;
            Name = name;
            MaxHealth = health;
            Defence = defence;
            Dead = false;
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
            if (Dead)
            {
                Console.WriteLine($"Персонаж, {Name}, не может двигаться - он мертв");
            }
            else
            {
                Console.WriteLine("Is moving");
            }
            
        }

        public void TakeDamage(int damage)
        {
            if (Defence >= damage)
            {
                Console.WriteLine("Противник заблокировал атаку");
            }
            else
            {
                Health -= (damage - Defence);
            }
        }

        public void TakeHeal(int healAmount)
        {
            throw new NotImplementedException();
        }

        public event HealthChangedDelegate HealthIncreasedEvent;

        public event HealthChangedDelegate HealthDecreasedEvent;
    }
}
