using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Bishop: MilitaryUnit
    {
        private int _healing;

        public int Healing
        {
            get { return _healing; }
            set { _healing = value; }
        }

        public Bishop(int health, string? name, int defense, int _DamageMax, int _DamageMin) : base(60, "Bishop", 30, 60, 20)
        {
            _healing = 60;
        }

        public void HealMagic(MagicUnit magicUnit)
        {
            while(magicUnit.Health < magicUnit.Max_healt)
            {
                magicUnit.Health++;
                _healing -= 2;
            }

        }
    }
}
