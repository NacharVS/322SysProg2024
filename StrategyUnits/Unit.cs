namespace StrategyUnits
{
    internal class Unit
    {
        private double _health;
        private string? _name;

        public int _MaxHealth;
        public int Defence { get; set; }
        public int MaxHealth { get; private set;  }

        public Unit(int health,int defence,  string? name)
        {
            _health = health;
            _name = name;
            Defence = defence;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

       

        public int maxhealth
        {
            get { return _MaxHealth; }
            set { _MaxHealth = value; }
        }

        public double Health
        {
            get
            {
                return _health;
            }
            set
            {
                if (value < 0)
                {
                    _health = 0;
                }
                else
                {
                    if (value > maxhealth)
                    {
                        _health = maxhealth;
                    }
                    else
                    {
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

        public void Move()
        {
            Console.WriteLine("Is moving");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Unit: {_name} Health: {_health}");
        }
    }
}
