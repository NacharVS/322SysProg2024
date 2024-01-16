using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MagicUnit:MilitaryUnit
    {
        private int _energy;
        public int Energy { get => _energy; set { _energy = value; } }
        public MagicUnit(int health, string? name, bool life, int defence, int maxddamage, int mindamage) : base(health, name, life, defence, maxddamage, mindamage) 
        {
            _energy = 60;
        }
        public override void ShowInfo()
        {
            if (Life)
            {
                Console.WriteLine($"Unit: {Name} Health: {Health} Energy: {Energy}");
            }
            else base.ShowInfo();
        }
    }
}
