namespace StrategyUnits
{
    internal class Unit
    {
        private int _health;
        private string? _name;

        public int MaxHeath { get; private set; }
        public bool IsAlive { get => _health > 0; }
        public int Defence { get; set; }

        public Unit(int health, string? name, int defence)
        {
            _health = health;
            _name = name;
            MaxHeath = health;
            Defence = defence;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int Health 
        { 
            get => _health; 
            set
            {
                if(value < 0) 
                {
                    _health = 0;
                }
                else
                {
                    if(value > MaxHeath)
                    {
                        _health = MaxHeath;
                    }
                    else
                    {
                        _health = value;
                    }
                }
            } 
        }

        public int RemovedHealth
        {
            get => MaxHeath - Health;
        }

        public void Move()
        {
            if (IsAlive)
            {
                Console.WriteLine("Is moving");
            }
            else
            {
                Console.WriteLine($"{Name} не может двигатся т.к. умер");
            }
        }

        public virtual void ShowInfo(string additionalText = "")
        {
            Console.WriteLine($"Unit: {_name} Health: {_health}/{MaxHeath}. {additionalText}");
        }

        public void GetDamage(int damage)
        {
            Health -= damage - Defence;
        }

        public void GetHeal(int healAmount)
        {
            Health += healAmount;
        }
    }
}
