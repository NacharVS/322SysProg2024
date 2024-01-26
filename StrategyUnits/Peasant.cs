using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal class Peasant : Unit, IShowInfo
    {
        public Peasant() : base(30, "Peasant", 0)
        {
            
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Unit: {Name} Health: {Health}/{MaxHealth} Defence: {Defence}");
        }
    }
}
