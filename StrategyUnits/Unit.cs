namespace StrategyUnits
{
    internal class Unit
    {
        private int Currenthealth;
        private string? _name;
        private bool alive = true;
        private int _defence;
        public delegate void HealthDelegate(int Health);

        public event HealthDelegate OnHealthIncreased;
        public event HealthDelegate OnHealthDecreased;
        public event HealthDelegate OnHealthLoss;
        public event HealthDelegate OnHealthWin;

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
        public int Defence
        {
            get { return _defence; }
            set { _defence = value; }
        }

        public void Move()
        {
            Console.WriteLine("Is moving");
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Unit: {_name} Health: {Currenthealth}");
        }
        public void GetsDamage(int Damage)
        {
            if (Damage <= Defence)
            {
                Defence -= Damage;
            }
            else
            {
                Health -= Damage - Defence;
                Defence = 0;
                if (Currenthealth <= 0)
                {
                    Currenthealth = 0;
                }
            }
            OnHealthWin?.Invoke(Currenthealth);
        }
        
     
    }
}
