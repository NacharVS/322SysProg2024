using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MilitoryUnit : Unit
    {
        public int MaxDamage;
        public int MinDamage;

        private Random random = new Random();

        public MilitoryUnit(int health, string? name, int defence, int minDamage, int maxDamage) : base(health, name, defence)
        {
            MaxDamage= maxDamage;
            MinDamage= minDamage;
        }

        public int RandomDamage
        {
            get { return random.Next(MinDamage, MaxDamage);}
        }

        public void InflictDamage(Unit unit)
        {
            int damage = RandomDamage;
            if (Dead)
            {
                Console.WriteLine("Атака не может быть проведена - атакующий персонаж мертв");
            }
            else if (unit.Dead)
            {
                Console.WriteLine("Атака не может быть проведена - персонаж, которого атакуют, мертв");
            }
            else
            {
                if (unit.Defence >= damage)
                {
                    Console.WriteLine("Противник заблокировал атаку");
                }
                else
                {
                    unit.Health -= (damage - unit.Defence);
                }
            }
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Unit: {Name} Health: {Health}/{MaxHealth} Defece: {Defence} Damage: {MinDamage}-{MaxDamage}");
        }
    }
}
