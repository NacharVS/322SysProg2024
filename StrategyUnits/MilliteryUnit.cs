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
        public MilliteryUnit(int health, string? name, int maxdamage, int mindamage) : base(health, name)
        {
            MaxDamage = maxdamage;
            MinDamage = mindamage;
        }
        
    }
}
