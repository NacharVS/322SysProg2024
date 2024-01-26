namespace StrategyUnits
{
    internal class Bishop : Unit, IMilitary, IMagic
    {
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public int Mana
        {
            get { return _mana; }
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
                        _mana = MaxMana;
                    }
                    else
                    {
                        _mana = value;
                    }
                }
            }
        }

        public int MaxMana { get; set; }

        private int _mana;
        private Random random = new Random();

        public Bishop(int health, string? name, int minDamage, int maxDamage, int mana) : base(health, name)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            MaxMana = mana;
            Mana = mana;
        }

        public void Attack(IHealthController unit)
        {
            unit.TakeDamage(CountDamage());
        }

        public double CountDamage()
        {
            return random.Next(MinDamage, MaxDamage);
        }

        public void Heal(IHealthController unit)
        {
            if (!IsAlive)
            {
                base.ShowInfo("Не может никого лечить т.к. мертв.");
                return;
            }

            if (!unit.IsAlive)
            {
                Console.WriteLine($"{Name} не может лечить, т.к. пациент мертв.");
                return;
            }

            if (Mana >= 2)
            {
                double lives = Math.Min(unit.RemovedHealth, Mana / 2);
                unit.TakeHeal(lives);
                Mana -= Convert.ToInt32(Math.Ceiling(lives * 2));
                Console.WriteLine($"{Name} восстановил пациенту {lives} жизней.");
            }
            else
            {
                Console.WriteLine($"У {Name} нет энергии для лечения.");
            }
        }
    }
}
