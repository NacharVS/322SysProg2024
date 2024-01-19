using System;
using System.Reflection.Metadata.Ecma335;

namespace StrategyUnits
{
    internal class Unit
    {
        public delegate void HealthChangedDelegate(double health);
        private double _currentHealth;
        private string? _name;
        public int Defense { get; set ; }
        public int MaxHealth { get; private set; }
        public bool IsAlive { get =>_currentHealth>0;}
        public Unit(int health,int defense ,string? name)
        {
            Defense = defense;
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
            get
            {
                return _currentHealth;
            }
           private set 
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
            get => MaxHealth-Health;
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
            Console.WriteLine($"Unit: {_name} Health: {_currentHealth}/{MaxHealth}. Defense:{Defense} " + text);
        }
     
        public void GetDamage(double damage)
        {
                if (Defense < damage)
                {
                Health -= damage - Defense;
                }
                else
                Console.WriteLine("Damage is fully absorbed by unit defense!");
        }
        public virtual void GetHeal(double healAmount)
        {
            if(healAmount>0)
            Health += healAmount;            
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
