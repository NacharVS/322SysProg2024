namespace StrategyUnits
{
    internal class Unit
    {
        private int _health;
        private string? _name;
        public int _MaxHealth { get; private set; }
        private int _energy;
        private int _defence;
        private bool _life;
        public int _MaxEnergy { get; private set; }

        public Unit(int health, string? name, int energy, bool life, int defence)
        {
            _life = life = true;
            _health = health;
            _name = name;
            _MaxHealth = _health;
            _energy = energy;
            _MaxEnergy = _energy;
            _defence = defence;
        }
        public bool Life
        {
            get => _life; set => _life = value;
        }
        public int Defence
        {
            get { return _defence; }
            set { _defence = value; }
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
                    if (value > _MaxHealth)
                    {
                        _health = _MaxHealth;
                    }
                    else
                    {
                        _health = value;
                    }
                }
            }
        }
        public int Energy
        {
            get
            {
                return _energy;
            }
            set
            {
                if (value < 0)
                {
                    _energy = 0;
                }
                else
                {
                    if (value > _MaxEnergy)
                    {
                        _energy = _MaxEnergy;
                    }
                    else
                    {
                        _energy = value;
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
            if (_life == true)
            {
                Console.WriteLine($"Unit: {_name} Health: {_health}");
            }
            else { Console.WriteLine($"Unit: {_name} Dead"); }


        }
    }
}
