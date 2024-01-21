using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MilliteryUnit : Unit 
    {
        public int MaxDamage { get; set; }
        public int MinDamage { get; set; }
        Random random = new Random();

            public MilliteryUnit (int health, string? name, int _maxdamage, int _mindamage, int defense) : base(health, name)
            {
                MaxDamage = _maxdamage;
                MinDamage = _mindamage;
            }
            private int damage;
            public void Damage(Unit unit)
            {
                int countdamage = random.Next(MinDamage, MaxDamage);
                countdamage -= unit.Defense;
                unit.Health -= Math.Max(0, countdamage);
            }

            public override void ShowInfo()
            {
                Console.WriteLine($"Unit: {Name} Health: {Health} MaxHealth: {MaxHealth} MaxDamage:{MaxDamage} MinDamage:{MinDamage} Defence:{Defense}");
            }
    }
    
            

        
}
