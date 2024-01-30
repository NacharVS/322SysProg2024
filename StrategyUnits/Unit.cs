using System.ComponentModel.DataAnnotations;

namespace StrategyUnits
{
    internal class Unit : IHealthControl, IShowInfo
    {
        private int _health;
        private string? _name;
        private int _maxHealth ;
        public delegate void ChangeUnitHP(int health);

        public event ChangeUnitHP HealthIncreasedEvent;
        public event ChangeUnitHP HealthDecreasedEvent;

        public Unit(int health, string? name)
        {
            Health = health;
            _name = name;
            MaxHealth = _health;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Health { get; set ; }
        public int MaxHealth { get { return _maxHealth; } set { _maxHealth = value; } }

        public void Move()
        {
            Console.WriteLine("Is moving");
        }

        public void ShowInfo()
        {

            Console.WriteLine($"Unit: {_name} Health: {_health}");
        }

        public void TakeDamage(Unit unit, int _damage)
        {
            if (_damage >= unit.Health) { unit.Health = 0; }
            else { unit.Health -= _damage; }
            HealthDecreasedEvent.Invoke(_damage);
        }

        public void GetHealth(Unit unit,int _health)
        {
            if (unit.Health != unit.MaxHealth) { unit.Health += unit._health; }
            else { Console.WriteLine("MAX HP"); }
            HealthIncreasedEvent.Invoke(unit.Health);


        }
    }
}
