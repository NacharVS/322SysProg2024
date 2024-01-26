namespace StrategyUnits
{
    internal class Zealot : Unit, IArmoredUnit, IBattleUnit, IMagicUnit, IPaladin, IArmorOfFaith
    {
        public int Armor { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
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
                    if (value > MaxEnergy)
                    {
                        _energy = MaxEnergy;
                    }
                    else
                    {
                        _energy = value;
                    }
                }
            }
        }
        private int _energy;
        public int MaxEnergy { get; set; }
        private Random random = new Random();
        public Zealot(int health, string? name, int minDamage, int maxDamage, int energy, int armor) : base(health, name)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Armor = armor;
            MaxEnergy = energy;
            Energy = energy;
            HealthIncreasedEvent += ArmorOfFaith;
            HealthDecreasedEvent += ArmorOfFaith;
        }
        private void ArmorOfFaith(double health)
        {
            if (health < MaxHealth *0.3 && !IsArmorOfFaith)
            {
                IsArmorOfFaith = true;
                Armor += Armor;
            }
            else if (health > MaxHealth *0.3&& IsArmorOfFaith)
            {
                IsArmorOfFaith = false;
                Armor -= Armor/2;
            }
        }
        public void Attack(IHealthController unit)
        {
            unit.TakeDamage(CountDamage());
        }
        public double CountDamage()
        {
            double damage = random.Next(MinDamage, MaxDamage);
            return damage;
        }
        public void Prayer()
        {
            if (Energy >= 10)
            {
                Energy -= 10;
                TakeHeal(20);
            }
            else
            {
                Console.WriteLine($"{Name} don't have enough energy to cast this spell! ");
            }
        }

        public void SaintTouch(Unit unit)
        {
            if (Energy >= 9)
            {
                unit.TakeDamage(CountDamage() * 2);
                Energy -= 9;
            }
            else
            {
                Console.WriteLine($"{Name} don't have enough energy to cast this spell! ");
            }
        }

        public bool IsArmorOfFaith { get; set; }
    }
}
