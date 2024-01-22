namespace StrategyUnits
{
    internal class Unit
    {

        public delegate void HealthChangedDelegate(double health);
        private double _health;
        private string? _name;

        public int _MaxHealth;
        public int Defence { get; set; }
        public int MaxHealth { get; private set; }
        

        public Unit(int health,int defence,  string? name)
        {
            _health = health;
            _name = name;
            Defence = defence;
            HealthIncreasedEvent += HealthIncreased;
            HealthDecreasedEvent += HealthDecreased;
            MaxHealth = health;
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
                return _health;
            }
            private set
            {
                if (value < 0)
                {
                    _health = 0;
                }
                else
                {
                    if (value > MaxHealth)
                    {
                        _health = MaxHealth;
                   
                    }
                    else
                    {
                        if (value > _health)
                            HealthIncreasedEvent?.Invoke(value);
                        else if (value < _health)
                            HealthDecreasedEvent?.Invoke(value);
                        _health = value;
                    }
                }
            }
        }
        public double RemovedHealth { get => MaxHealth - Health; }
        public void GetDamage(double damage)
        {
            if (damage > Defence)
                Health -= damage - Defence;
        }

        public virtual void GetHeal(double healAmount)
        {
            if (healAmount > 0)
                Health += healAmount;
        }

        public event HealthChangedDelegate HealthIncreasedEvent;

        public event HealthChangedDelegate HealthDecreasedEvent;

        public void Move()
        {
            Console.WriteLine("Is moving");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Unit: {_name} Health: {_health}");
        }
        public static void HealthDecreased(double number)
        {
            Console.WriteLine($"Health has decreased. Current health: {number}");
        }

        public static void HealthIncreased(double number)
        {
            Console.WriteLine($"Health has increased. Current health: {number} ");
        }
    }
}
