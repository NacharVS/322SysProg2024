using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Palladin: MagicUnit
    {
        private int _attacca;

        public int Attacca
        {
            get { return _attacca; }
            set { _attacca = value; }
        }

        public Palladin() : base(60, "Palladin")
        {
            _attacca = 8;
        }

        public MagicAttacca (Unit unit)
        {
            unit.Health -= _attacca;
        }
    }
}
