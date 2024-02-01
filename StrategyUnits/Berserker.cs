using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyUnits.Interfaces;

namespace StrategyUnits
{
    internal class Berserker : Unit, IRage, IShowInfo, IFrenzy
    {
        public Berserker(int health, string? name, int defence, int minDamage, int maxDamage) : base(health, name, defence)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            RageInfo = false;
            FrenzyInfo = false;
        }

        private Random random = new Random();

        public int MaxDamage { get; set; }
        public int MinDamage { get; set; }

        public int RandomDamage => random.Next(MinDamage, MaxDamage);

        public bool RageInfo { get; set; }
        public bool FrenzyInfo { get; set; }

        public void Frenzy(IHealthController unit)
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
                if (Health < (double)MaxHealth/100*30 && FrenzyInfo)
                {
                    FrenzyInfo = true;
                    unit.TakeDamage(damage + damage*5);
                }
                else if (Health >= (double)MaxHealth / 100 * 30 && FrenzyInfo)
                {
                    FrenzyInfo = false;
                    unit.TakeDamage(damage);
                }

            }
        }

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
