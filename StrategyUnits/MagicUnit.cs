using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MagicUnit : MiliataryUnit
    {
        protected int _mana;

        public int Mana
        {
            get { return _mana; }
            set
            {
                if (value < 0)
                {
                    _mana = 0;
                }
                else
                {
                    if (value > MaxHeath)
                    {
                        _mana = MaxHeath;
                    }
                    else
                    {
                        _mana = value;
                    }
                }
            }
        }

        public int RemovedMana { get => MaxMana - Mana; }

        public int MaxMana;

        public MagicUnit(int health, string? name, int minDamage, int maxDamage, int defence, int energy) : base(health, name, minDamage, maxDamage, defence)
        {
            _mana = energy;
            MaxMana = Mana;
        }
    }
}
