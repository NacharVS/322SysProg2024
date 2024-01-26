using System;

namespace StrategyUnits
{
    internal class Footman : Unit, IMilitoryUnit, IShowInfo, IRage
    {
        private int _health;
        private bool _rage = false;
        private int _minDamage;
        private int _maxDamage;
        public int MaxDamage { get; set; }
        public int MinDamage { get; set; }

        private Random random = new Random();

        public Footman(int health, string? name, int defence, int minDamage, int maxDamage) : base(health, name, defence)
        {
            _health = health;
            _minDamage = minDamage;
            _maxDamage = maxDamage;
        }

        public int RandomDamage => random.Next(_minDamage, _maxDamage);

        public void InflictDamage(IHealthController unit)
        {
            int damage = RandomDamage;
            if (Dead)
            {
                Console.WriteLine($"Атака не может быть проведена - атакующий персонаж, {Name}, мертв");
            }
            else if (unit.Dead)
            {
                Console.WriteLine($"Атака не может быть проведена - персонаж, {unit.Name}, которого атакуют, мертв");
            }
            else
            {
                unit.TakeDamage(damage);
            }
        }

        public void Rage()
        {
            int damage = RandomDamage;
            if (Dead)
            {
                Console.WriteLine($"Умение не может быть проведено - выбранный персонаж, {Name}, мертв");
            }
            else
            {
                if (Health <= MaxHealth / 2 && !_rage)
                {
                    _rage = true;
                    MaxDamage += MaxDamage / 2;
                    MinDamage += MinDamage / 2;
                }
                else if (Health > MaxHealth / 2 && _rage)
                {
                    _rage = false;
                    MaxDamage -= MaxDamage / 2;
                    MinDamage -= MinDamage / 2;
                }
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Unit: {Name} Health: {Health}/{MaxHealth} Defece: {Defence} Damage: {_minDamage}-{_maxDamage}");
        }
    }
}
