namespace StrategyUnits
{
    internal class Unit
    {
        private int _currenthealth;
        private string? _name;
        
        public int MaxHealth { get; private set; }

        public Unit(int health, string? name) 
        {
            _currenthealth = health;
            _name = name;
            MaxHealth = health;

        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Health 
        { 
            get
            {
                return _currenthealth;
            }
            set
            {
                if(value<0)
                {
                    _currenthealth = 0;
                }
                else
                {
                    if (value > MaxHealth)
                        _currenthealth = MaxHealth;
                    else
                        _currenthealth = value;
                }
            }
        }
        public int Defense { get; set; }
        
        public void Move()
        {
            Console.WriteLine("Is moving");
        }
       
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Unit: {_name} Health: {_currenthealth} MaxHealth: {MaxHealth}");
        }
    }
}
