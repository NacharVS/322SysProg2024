namespace StrategyUnits
{
    internal class Unit
    {
        private int Currenthealth;
        private string? _name;
        private bool alive = true;
        public bool Alive
        {
            get { return alive; }
        }
        public int MaxHealth { get; private set; }

        public Unit(int health, string? name)
        {
            Currenthealth = health;
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
            get => Currenthealth; 
            set
            {
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

        public void Move()
        {
            Console.WriteLine("Is moving");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Unit: {_name} Health: {Currenthealth}");
        }
    }
}
