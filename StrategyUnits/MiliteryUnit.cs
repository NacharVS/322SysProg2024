using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal class MiliteryUnit : Unit
    {
        public int DamangeMax { get; set; }
        public int DamangeMin { get; set; }
        Random random = new Random();

        public MiliteryUnit(int health, string? name, int _damangemax, int _damangemin, int defense) : base(health, name)
        {
            DamangeMax = _damangemax;
            DamangeMin = _damangemin;
        }
        private int damange;
        public void InflictDamage(Unit unit)
        {
            int countdamange = random.Next(DamangeMin, DamangeMax);
            countdamange -= unit.Defense;
          unit.Health-= Math.Max(0, countdamange);
        }
      

        public override void ShowInfo()
        {
            Console.WriteLine($"Unit: {Name} Health: {Health} MaxHealth: {MaxHealth} DamangeMax:{DamangeMax} DamangeMin:{DamangeMin} Defence:{Defense}");
        }
    }
}
