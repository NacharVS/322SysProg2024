using System.ComponentModel.DataAnnotations;

namespace StrategyUnits
{
    internal class Unit
    {
        private int _currenthealth;
        private string? _name;
        private int _energy;

        public int MaxHealth { get; private set; }

        public Unit(int health, string? name)
        {
            _currenthealth = health;
            _name = name;
            MaxHealth = health;
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
                    if(_currenthealth > MaxHealth)
                        _currenthealth = MaxHealth;
                    else
                        _currenthealth = value;
                }
                _currenthealth = value;
            }
        }

        public void Move()
        {
            Console.WriteLine("Is moving");
        }

        public virtual void ShowInfo() 
        {
            Console.WriteLine($"Unit: {_name} Health: {_currenthealth}");
        }
    }
}
