using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MagicUnit : MilitaryUnit
    {
        public int _energy;
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
                else
                {
                    if (value > MaxEnergy)
                    {
                        _energy = MaxEnergy;
                    }
                    else
                    {
                        _energy = value;
                    }
                }
            }
        }
        public int RemovedEnergy
        {
            get => MaxEnergy - Energy;
        }

        public int MaxEnergy;
        public MagicUnit(int health, int mindamage, int maxdamage, int defense,int energy, string? name) : base(health,mindamage,maxdamage ,defense, name)
        {
            _energy= energy;
            MaxEnergy = Energy;
        }
        public override void ShowInfo(string text = "")
        {

            base.ShowInfo($"Energy: {_energy}/{MaxEnergy}");

        }
    }
}
