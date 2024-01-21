using System.Runtime.CompilerServices;

namespace StrategyUnits
{
    internal class Unit
    {
        private double Currenthealth;
        private string _name;
        private bool alive = true;
        private double _defence;
        public delegate void HealthChangeDelegate(double Health);

        public double Defence
        {
            get { return _defence; }
            set { _defence = value; }
        }
        public bool Alive
        {
            get { return alive; }
        }
        public int MaxHealth { get; private set; }
        
        public void TakeDamage(double Damage)
        {
            if (!Alive)
            {
                Console.WriteLine("Действие не выполнено, юнит погиб");
                return;
            }
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

        public double Health 
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
        public virtual void GetHeal(double CountHP)
        {
            if (Alive)
            {
                Health += CountHP;
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
