using System.ComponentModel.DataAnnotations;

namespace StrategyUnits
{
    internal class Unit : IHealthControl, IShowInfo
    {
        private int _health;
        private int _maxhealth;
        private string? _name;
       
        public int _altar = 5000;
        

        public int MaxHealth { get; set; }

        public Unit(int health, string? name)
        {
            _name = name;
            Health = health;
            MaxHealth = _health;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
      
        public int Health { get; set; }
        public int maxhealth 
        { 
            get { return _maxhealth; } 
            set { _maxhealth = value; } 
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
            Console.WriteLine($"Unit: {_name} Health: {_currenthealth} MaxHealth {MaxHealth} Mana: {_energy} altar: {_altar}");
        }

        public void Altar(int Amount)
        {
            _energy += Amount;
            _altar -= Amount;
        }
    }
}
