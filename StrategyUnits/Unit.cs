namespace StrategyUnits
{
    internal class Unit
    {
        private int _health;
        private string? _name;

        public int MaxHeath { get; private set; }
        public bool IsAlive { get => _health > 0;}

        public Unit(int health, string? name)
        {
            _health = health;
            _name = name;
            MaxHeath = health;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Health 
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
        }

        public virtual void ShowInfo(string additionalText = "")
        {
            Console.WriteLine($"Unit: {_name} Health: {_health}. {additionalText}");
        }
    }
}
