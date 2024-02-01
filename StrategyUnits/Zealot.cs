using StrategyUnits.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Zealot : Unit, IShowInfo, IPrayer, IMilitoryUnit
    {
        public Zealot(int health, string? name, int defence, int minDamage, int maxDamage, int energy) : base(health, name, defence)
        {
            CheackArmor = false;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Energy = energy;
            MaxEnergy = energy;
        }
        public bool CheackArmor { get; set; }

        public int MaxEnergy { get; set; }

        public int EnergySpent => (MaxEnergy - Energy);

        public int Energy { get; set; }
        public int MaxDamage { get; set; }
        public int MinDamage { get; set; }

        private Random random = new Random();
        public int RandomDamage => random.Next(MinDamage, MaxDamage);

        public void ArmorOfFaith()
        {
            if (Dead)
            {
                Console.WriteLine($"Невозможно выполнить это действие - персонаж, {Name}, мертв");
            }
            else
            {
                if (Health <= (double)MaxHealth / 100 * 30 && !CheackArmor)
                {
                    CheackArmor = true;
                    Defence += Defence;
                }
                else if (Health > (double)MaxHealth / 100 * 30 && CheackArmor)
                {
                    CheackArmor = false;
                    Defence -= Defence;
                }
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Unit: {Name} Health: {Health}/{MaxHealth} Energy: {Energy}/{MaxEnergy} Defece: {Defence} Damage: {MinDamage}-{MaxDamage}");
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
    }
}
