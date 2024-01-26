namespace StrategyUnits
{
    internal class Unit
    {
        private double Currenthealth;
        private string _name;
        private bool alive = true;
        public delegate void HealthChangeDelegate(double Health);

        public bool Alive
        {
            get { return alive; }
        }

        public double maxHealth { get; set; }

        

        public Unit(int _health, string name)
        {
            Currenthealth = _health;
            _name = name;
            maxHealth = _health;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }//event
        }

        public double health
        {
            get => Currenthealth;
            set
            {
                if (Currenthealth > value)
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
                    else if (value >= maxHealth)
                    {
                        Currenthealth = maxHealth;
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
                health += CountHP;
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
        
    }
}
