using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyUnits.Interfaces;

namespace StrategyUnits
{
    internal class Paladin : Unit, IMilitoryUnit, IPrayer, ISacredBlow, IShowInfo
    {
        public int EnergyCost { get; set; }
        public int MaxDamage { get; set; }
        public int MinDamage { get; set; }

        private Random random = new Random();
        public int RandomDamage => random.Next(MinDamage, MaxDamage);

        public int MaxEnergy { get; set; }

        public int EnergySpent => (MaxEnergy - Energy);

        public int Energy { get; set; }

        public Paladin(int health, string? name, int defence, int minDamage, int maxDamage, int energy) : base(health, name, defence)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Energy = energy;
            MaxEnergy = energy;

        }

        public void SacredBlow(IHealthController unit)
        {
            EnergyCost = 20;
            int damage = 20;
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
                Energy -= EnergyCost;
            }
        }
        public void Prayer()
        {
            if (Dead)
            {
                Console.WriteLine($"Способность нельзя использовать - персонаж, {Name}, мертв");
            }
            else
            {
                if (Health == MaxHealth)
                {
                    Console.WriteLine($"У персонажа, {Name}, максимальное здоровье - навык не сработал");
                }
                else if (Energy < 10)
                {
                    Console.WriteLine($"У персонажа, {Name}, недостаточно энергии - невозможно использовать этот навык");
                }
                else
                {
                    Health += 20;
                    Energy -= 10;
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

        public void ShowInfo()
        {
            Console.WriteLine($"Unit: {Name} Health: {Health}/{MaxHealth} Energy: {Energy}/{MaxEnergy} Defece: {Defence} Damage: {MinDamage}-{MaxDamage}");
        }
    }
}
