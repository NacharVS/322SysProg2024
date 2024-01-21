using System.ComponentModel.DataAnnotations;

namespace StrategyUnits
{
    internal class Unit
    {
        private int _health;
        private string? _name;
        private int _defence;
        private int _maxHealth { get; set; }
        public delegate void ChangeUnitHP(int health);

        public event ChangeUnitHP HealthIncreasedEvent;
        public event ChangeUnitHP HealthDecreasedEvent;


        public bool Alive = true;

        public int MaxHealth
        {
            get { return _maxHealth; }

        }
        public Unit(int health, string? name, int defence)
        {
            _health = health;
            _name = name;
            _maxHealth = _health;
            _defence = defence;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Defence
        {
            get { return _defence; }
            set { _defence = value; }
        }

        public int Health
        {
            get => _health;
            set
            {
                if (value < 0)
                {
                    if (_health <= value)
                    {
                        _health = 0;
                        Alive = false;
                        Console.WriteLine("RIP...");
                    }
                    else
                    {
                        _health -= value;
                    }
                    HealthDecreasedEvent.Invoke(value);
                }
                else
                {
                    if (value > _maxHealth)
                    {
                        _health = _maxHealth;
                    }
                    else
                    {
                        _health += value;
                    }
                    HealthIncreasedEvent.Invoke(value);
                }
            }
        }


        public void Move()
        {
            Console.WriteLine("Is moving");
        }

        public virtual void ShowInfo()
        {

            Console.WriteLine($"Unit: {_name} Health: {_health} Alive: {Alive} ");
        }
    }
}
