using System;

namespace StrategyUnits
{
    internal class Bishop : Unit, IMagicUnit, IBattleUnit, IHealer
    {
        public int _energy;
        private Random random = new Random();

        public Bishop(int health, string? name, int minDamage, int maxDamage, int energy) : base(health, name)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            _energy = energy;
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
        public int MaxEnergy { get; set; }
        public int MinDamage { get ; set ; }
        public int MaxDamage { get ; set ; }

        public void Attack(IHealthController unit)
        {
            unit.TakeDamage(CountDamage());
        }

        public double CountDamage()
        {
            double damage = random.Next(MinDamage, MaxDamage);
            return damage;
        }

        public void HealUnit(Unit unit)
        {
            if (!IsAlive)
            {
                Console.WriteLine("This unit is DEAD");
                return; 
            }
            if (_energy >= 2)
                {
                double lives = Math.Min(unit.RemovedHealth, _energy/2);
                    unit.TakeHeal(lives);
                    Energy -= Convert.ToInt32(Math.Ceiling(lives *2));
                }
                else
                {
                    Console.WriteLine("Not enough energy!");
                }
        }
        
    }
}
