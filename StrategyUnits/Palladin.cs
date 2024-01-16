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
        private int _Magicattacca;

        public int Attacca
        {
            get { return _attacca; }
            set { _attacca = value; }
        }

        public int MagicAttacca
        {
            get { return _Magicattacca; }
            set { _Magicattacca = value; }
        }

        public Palladin() : base(60, "Palladin")
        {
            _attacca = 8;
            _Magicattacca = 8;
        }

        public void PalladinAttacca (Unit unit)
        {
            unit.Health -= _attacca;
        }

        public void PalladinMagicAttacca(Unit unit)
        {
            unit.Health -= _attacca;
        }

    }
}
