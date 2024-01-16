using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MilitoryUnit : Unit
    {
        private int _damage;
        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }
        private int _defence;
        public int Defence
        {
            get { return _defence; }
            set { _defence = value; }
        }
        public int _block;
        public virtual int Block
        {
            get { return _block; }
            set
            {
                if (Damage > Defence)
                {
                    _block = Damage - Defence;
                }
                else
                {
                    _block = 0;
                }
            }
        }
        public MilitoryUnit(int health, string? name) : base(health, name)
        {

        }
    }
}
