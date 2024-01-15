namespace StrategyUnits
{
    internal class Unit
    {
        private int _currenthealth;
        private string? _name;
        public int _MaxHealth;
        public int _mana;
        public int _MaxMana;
        public int _fountain = 5000;

        public int MaxHealth { get; private set; }

        public Unit(int health, int maxhealth, int mana, int MaxMana, string? name)
        {
            _currenthealth = health;
            _name = name;
            _MaxHealth = maxhealth; 
            _mana = mana;
            _MaxMana = MaxMana;
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

        public int MaxMana
        {
            get { return _MaxMana; }
            set { _MaxMana = value; }
        }
        public int Health 
        { 
            get
            {
                return _currenthealth;
            }
            set
            {
                if (value < 0)
                {
                    _currenthealth = 0;
                }
                else
                {
                    if (value > maxhealth)
                    {
                        _currenthealth = maxhealth;
                    }
                    else
                    {
                        _currenthealth = value;
                    }
                }
            }
        }

        public int Mana
        {
            get
            {
                return _mana;
            }
            set
            {
                if (value < 0)
                {
                    _mana = 0;
                }
                else
                {
                    if (value > MaxMana)
                    {
                        _mana = _MaxMana;
                    }
                    else
                    {
                        _mana = value;
                    }
                }
            }
        }

        public void Move()
        {
            Console.WriteLine("Is moving");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Unit: {_name} Health: {_currenthealth} Mana: {Mana} fountain: {_fountain}");
        }

        public void Fountain(int Amount)
        {
            Mana += Amount;
            _fountain -= Amount;
        }
    }
}
