using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MilitoryUnit : Unit
    {
        private int _damage;
        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

        
        public MilitoryUnit(int health, string? name, int defence, int damage) : base(health, name, defence)
        {
            _damage = damage;
        }

        public void InflictDamage(Unit unit)
        {
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
                if (unit.Defence >= Damage)
                {
                    Console.WriteLine("Противник заблокировал атаку");
                }
                else
                {
                    unit.Health -= (Damage - unit.Defence);
                }
            }
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Unit: {Name} Health: {Health}/{MaxHealth} Defece: {Defence} Damage: {Damage}");
        }
    }
}
