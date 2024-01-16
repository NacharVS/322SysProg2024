namespace StrategyUnits
{
    internal class Unit
    {
        private int _curenthealth;
        private string? _name;
        private bool _life;
        public int MaxHealth { get; private set; }

        public Unit(int health, string? name, bool life)
        {
            _life = life = true;
            _curenthealth = health;
            _name = name;
            MaxHealth = _curenthealth;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public bool Life
        {
            get=> _life; set => _life = value;
        }
        public int Health
        {
            get => _curenthealth;
            set
            {
                if (value <= 0)
                {
                    _curenthealth = 0;
                    _life = false;
                }
                else
                {
                    if (value > MaxHealth)
                    {
                        _curenthealth = MaxHealth;
                    }
                    else
                    {
                        _curenthealth = value;
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
            if(_life == true)
            {
                Console.WriteLine($"Unit: {_name} Health: {_curenthealth}");
            }
            else { Console.WriteLine($"Unit: {_name} Dead"); }


        }
    }
}
