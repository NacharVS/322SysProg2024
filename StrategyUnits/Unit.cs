using System.ComponentModel.DataAnnotations;

namespace StrategyUnits
{
    internal class Unit : IHealthControl, IShowInfo
    {
        private int _health;
        private int _maxhealth;
        private string? _name;
       
        
        

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

      
        public void Move()
        {
            Console.WriteLine("Is moving");
        }

        public virtual void ShowInfo() 
        {
            Console.WriteLine($"Unit: {_name} Health: {Health} MaxHealth {MaxHealth}");
        }

        public void TakeDamage(Unit unit, int _damage)
        {
            throw new NotImplementedException();
        }

        public void GetHealth(Unit unit, int _health)
        {

           unit.Health += _health;
        }
    }
}
