namespace StrategyUnits
{
    internal class Footman : MilitoryUnit
    {
        private int _health;
        private bool _Rage = false;
        public Footman(int health, string? name, int defence, int minDamage, int maxDamage) : base(health, name, defence, minDamage, maxDamage)
        {
            _health = health;
        }
        public int Health
        {
            get { return _health; }
            set
            {
                if (Health < MaxHealth / 2 && !_Rage)
                {
                    _Rage = true;
                    MaxDamage += MaxDamage / 2;
                    MinDamage += MinDamage / 2;
                }
                else if (Health >= MaxHealth / 2 && _Rage)
                {
                    _Rage = false;
                    MaxDamage -= MaxDamage / 2;
                    MinDamage -= MinDamage / 2;
                }
            }
        }
        public void Rage(Unit unit)
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
                //if (Health < MaxHealth / 2)
                //{
                //    unit.TakingDamage(damage+damage/2);
                //}
                //else
                //{
                //    unit.TakingDamage(damage);
                //}
                if (Health <= MaxHealth / 2 && !_Rage)
                {
                    _Rage = true;
                    MaxDamage += MaxDamage / 2;
                    MinDamage += MinDamage / 2;
                }
                else if (Health > MaxHealth / 2 && _Rage)
                {
                    _Rage = false;
                    MaxDamage -= MaxDamage / 2;
                    MinDamage -= MinDamage / 2;
                }
            }
        }
    }
}
