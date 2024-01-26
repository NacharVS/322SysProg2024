namespace StrategyUnits
{
    internal class Paladin : Unit, IMagicUnit, IBattleUnit, IArmoredUnit, IPaladin
    {
        private Random random = new Random();
        public int Armor { get; set; }
        public int _energy;

        public Paladin(int health, string? name, int minDamage, int maxDamage, int energy, int armor) : base(health, name)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            _energy = energy;
            Armor = armor;
            MaxEnergy = Energy;
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
        public int MaxEnergy { get; set ; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }

        public void SaintTouch(Unit unit) 
        { 
        if (Energy >= 9)
            {
                unit.TakeDamage(CountDamage()*2);
                Energy -= 9;
            }
        else
            {
                Console.WriteLine($"{Name} don't have enough energy to cast this spell! ");
            }
        }
        public void Prayer()
        {
            if(Energy >= 10)
            {
                Energy -= 10;
                TakeHeal(20);
            }
            else
            {
                Console.WriteLine($"{Name} don't have enough energy to cast this spell! ");
            }
        }

        public void Attack(IHealthController unit)
        {
            unit.TakeDamage(random.Next(MinDamage, MaxDamage));
        }

        public double CountDamage()
        {
            double damage = random.Next(MinDamage, MaxDamage);
            return damage;
        }
        public override void TakeDamage(double damage)
        {
            if (Armor < damage)
            {
                Health -= damage - Armor;
            }
            else
                Console.WriteLine("Damage is fully absorbed by unit defense!");
        }
    }
}
