using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyUnits.Interfaces;
using static System.Net.Mime.MediaTypeNames;

namespace StrategyUnits
{
    internal class Bishop : Unit, IHeal, IShowInfo
    {
        public Bishop(int health, string? name, int defence, int energy) : base(health, name, defence)
        {
            Energy = energy;
            MaxEnergy = energy;
            EnergyCost = 2;
        }
        public int EnergyCost { get; set; }
        public int MaxEnergy { get; set; }
        public int EnergySpent => (MaxEnergy - Energy);
        public int Energy { get; set; }

        public void Healing(IHealthController unit)
        {
            if (Dead)
            {
                Console.WriteLine($"Исцеление не может быть проведено - исцеляющий персонаж, {Name}, мертв");
            }
            else if (unit.Dead)
            {
                Console.WriteLine($"Исцеление не может быть проведено - персонаж, {unit.Name}, которого исцеляют, мертв");
            }
            else
            {
                if (unit.MaxHealth-unit.Health <= Energy / 2)
                {
                    EnergyCost = unit.MaxHealth - unit.Health;
                    unit.TakeHeal(EnergyCost);
                    Energy -= EnergyCost*2;
                }
                else
                {
                    EnergyCost = Energy / 2;
                    unit.TakeHeal(EnergyCost);
                    Energy -= EnergyCost*2;
                }
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Unit: {Name} Health: {Health}/{MaxHealth} Energy: {Energy}/{MaxEnergy} Defece: {Defence}");
        }
    }
}
