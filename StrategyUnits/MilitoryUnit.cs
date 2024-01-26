using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MilitoryUnit : Unit
    {
        private int _maxDamage;
        private int _minDamage;

        public int MaxDamage { get; set; }
        public int MinDamage { get; set; }

        private Random random = new Random();

        public MilitoryUnit(int health, string? name, int defence, int minDamage, int maxDamage) : base(health, name, defence)
        {
            _maxDamage = maxDamage;
            _minDamage = minDamage;
        }

        public int RandomDamage => random.Next(_minDamage, _maxDamage);

        public void InflictDamage(Unit unit)
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
            Console.WriteLine($"Unit: {Name} Health: {Health}/{MaxHealth} Defece: {Defence} Damage: {_minDamage}-{_maxDamage}");
        }
    }
}
