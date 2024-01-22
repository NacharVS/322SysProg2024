namespace StrategyUnits
{
    internal class Unit
    {
        private int Currenthealth;
        private string? _name;
        private bool alive = true;
       public int Defence {  get; set; }
        
        
        

        public bool Alive
        {
            get { return alive; }
        }
        public int MaxHealth { get; private set; }

        public Unit(int health, string? name, int defence)
        {
            Currenthealth = health;
            _name = name;
            MaxHealth = health;
            Defence = defence;
            OnHealthIncreased += Health => Console.WriteLine($"У {Name} здоровье увеличено до {Health}.");
            OnHealthDecreased += Health => Console.WriteLine($"У {Name} здоровье уменьшено до {Health}.");
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
                        OnHealthDecreased?.Invoke(Currenthealth);
                    }
                    else if (value >= MaxHealth)
                    {
                        Currenthealth = MaxHealth;
                        OnHealthIncreased?.Invoke(Currenthealth);
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

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Unit: {_name} Health: {Currenthealth}");
        }

        public void GetDamage(int damage)
        {
            if (damage <= Defence)
            {
                int reflectedDamage = damage - Defence;
                Defence -= damage;
                Health -= reflectedDamage;
                Console.WriteLine($"{Name} отразил {reflectedDamage} урона с помощью защиты!");
            }
            else 
            {
                Defence -= damage;
            }
        }

        public virtual void GetHeal(int CountHeal)
        {
            if (CountHeal > 0)
                Health += CountHeal;
        }
        public delegate void HealthDelegate(int Health);
        public event HealthDelegate OnHealthIncreased;
        public event HealthDelegate OnHealthDecreased;
    }
}
//public void GetsDamage(int Damage)
//{
//    if (Damage <= Defence)
//    {
//        Defence -= Damage;
//    }
//    else
//    {
//        Health -= Damage - Defence;
//        Defence = 0;
//        if (Currenthealth <= 0)
//        {
//            Currenthealth = 0;
//        }
//    }
//    OnHealthWin?.Invoke(Currenthealth);
//}