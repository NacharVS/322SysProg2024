using System.Diagnostics.Tracing;

namespace StrategyUnits
{
    internal class Unit
    {
        public delegate void HealthChangedDelegate(int health);
        private int _curenthealth;
        private string? _name;
        private bool _life;
        private int _defence;
        public int MaxHealth { get; private set; }

        public Unit(int health, string? name, bool life, int defence)
        {
            _life = life = true;
            _curenthealth = health;
            _name = name;
            MaxHealth = _curenthealth;
            _defence = defence;
        }

        public int Defence 
        {
            get {  return _defence; }
            set { _defence = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public bool Life
        {
            get=> _life; set => _life = value;
        }
        public int Health
        {
            get => _curenthealth;
            set
            {
                if (_curenthealth < value)
                {
                    HealthIncreasedEvent?.Invoke(_curenthealth);
                    
                }
                else { HealthDecreasedEvent?.Invoke(_curenthealth); }
                if (value <= 0)
                {
                    _curenthealth = 0;
                    _life = false;
                }
                else
                {
                    if (value > MaxHealth)
                    {
                        _curenthealth = MaxHealth;
                    }
                    else
                    {
                        _curenthealth = value;
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
            if(_life == true)
            {
                Console.WriteLine($"Unit: {_name} Health: {_curenthealth}");
            }
            else { Console.WriteLine($"Unit: {_name} Dead"); }


        }
        public event HealthChangedDelegate HealthIncreasedEvent;

        public event HealthChangedDelegate HealthDecreasedEvent;
    }
}
