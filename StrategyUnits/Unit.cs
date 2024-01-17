using System.Runtime.CompilerServices;

namespace StrategyUnits
{
    internal class Unit
    {
        private int Currenthealth;
        private string _name;
        private bool alive = true;
        private int _defence;
        public delegate void HealthChangeDelegate(int Health);

        public int Defence
        {
            get { return _defence; }
            set { _defence = value; }
        }
        public bool Alive
        {
            get { return alive; }
        }
        public int MaxHealth { get; private set; }
        
        public void TakeDamage(int Damage)
        {
            if(Damage <= Defence)
            {
                HealthVSDefenceWin?.Invoke(Currenthealth);
                Defence -= Damage;
            }
            else
            {
                HealthVSDefenceWin?.Invoke(Currenthealth);
                Health -= Damage - Defence;
                Defence = 0;
                if (Currenthealth <= 0)
                {
                    Currenthealth = 0;
                    alive = false;
                    Console.WriteLine("Юнит погиб");
                }
            }
        }

        public Unit(int health, string name)
        {
            Currenthealth = health;
            _name = name;
            MaxHealth = health;
            Defence = _defence;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Health 
        { 
            get => Currenthealth; 
            set
            {
                if(Currenthealth > value)
                {
                    HealthDecreaseEvent?.Invoke(value);
                }
                else if (Currenthealth == value)
                {
                    
                }
                else
                {
                    HealthIncreaseEvent?.Invoke(value);
                }
                if (alive is false)
                {
                    Console.WriteLine("Юнит погиб. Действие не выполнено.");
                }
                else
                {
                    if (value <= 0)
                    {
                        Currenthealth = 0;
                        alive = false;
                    }
                    else if (value >= MaxHealth)
                    {
                        Currenthealth = MaxHealth;
                    }
                    else
                    {
                        Currenthealth = value;
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
            Console.WriteLine($"Unit: {_name} Health: {Currenthealth}");
        }
        public event HealthChangeDelegate HealthIncreaseEvent;
        public event HealthChangeDelegate HealthDecreaseEvent;
        public event HealthChangeDelegate HealthVSDefenceLose;
        public event HealthChangeDelegate HealthVSDefenceWin;
    }
}
