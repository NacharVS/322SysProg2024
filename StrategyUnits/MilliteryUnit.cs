using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MilliteryUnit : Unit 
    {
        public int MaxDamange { get; set; }
        public int MinDamange { get; set; }
        Random random = new Random();

            public MilliteryUnit (int health, string? name, int _maxdamange, int _mindamahge, int defense) : base(health, name)
            {
                MaxDamange = _maxdamange;
                MinDamange = _mindamahge;
            }
            private int damange;
            public void Damage(Unit unit)
            {
                int countdamange = random.Next(MinDamange, MaxDamange);
                countdamange -= unit.Defense;
                unit.Health -= Math.Max(0, countdamange);
            }

            public override void ShowInfo()
            {
                Console.WriteLine($"Unit: {Name} Health: {Health} MaxHealth: {MaxHealth} DamangeMax:{MaxDamange} DamangeMin:{MinDamange} Defence:{Defense}");
            }
    }
    
            

        
}
