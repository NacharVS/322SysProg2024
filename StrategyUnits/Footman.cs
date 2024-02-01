using System;
using StrategyUnits.Interfaces;

namespace StrategyUnits
{
    internal class Footman : Unit, IShowInfo, IRage
    {
        public int MaxDamage { get; set; }
        public int MinDamage { get; set; }
        public bool RageInfo {  get; set; }

        private Random random = new Random();

        public Footman(int health, string? name, int defence, int minDamage, int maxDamage) : base(health, name, defence)
        {
            RageInfo = false;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
        }


        public int RandomDamage => random.Next(MinDamage, MaxDamage);

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
            if (Dead)
            {
                Console.WriteLine($"Умение не может быть проведено - выбранный персонаж, {Name}, мертв");
            }
            else
            {
                if (Health <= MaxHealth / 2 && !RageInfo)
                {
                    RageInfo = true;
                    MaxDamage += MaxDamage / 2;
                    MinDamage += MinDamage / 2;
                }
                else if (Health > MaxHealth / 2 && RageInfo)
                {
                    RageInfo = false;
                    MaxDamage -= MaxDamage / 2;
                    MinDamage -= MinDamage / 2;
                }
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Unit: {Name} Health: {Health}/{MaxHealth} Defece: {Defence} Damage: {MinDamage}-{MaxDamage}");
        }
    }
}
