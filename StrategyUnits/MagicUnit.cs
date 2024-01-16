using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MagicUnit : MilitoryUnit
    {
        public int _energy;
        public int MaxEnergy { get; set; }
        public int EnergySpent
        {
            get
            {
                return (MaxEnergy - Energy);
            }
        }

        public MagicUnit(int health, string? name, int defence, int damage, int energy) : base (health, name, defence, damage)
        {
            _energy = energy;
            MaxEnergy = Energy;
        }
        public int Energy
        {
            get
            {
                return _energy;
            }
            set
            {
                if (value < 0)
                {
                    _energy = 0;
                }
                else if (MaxEnergy < value)
                {
                    _energy = MaxEnergy;
                }
                else
                {
                    _energy = value;
                }
            }
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Unit: {Name} Health: {Health}/{MaxHealth} Energy: {Energy}/{MaxEnergy} Defece: {Defence} Damage: {Damage}");
        }
    }
}
