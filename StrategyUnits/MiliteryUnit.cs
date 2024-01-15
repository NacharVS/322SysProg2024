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
        public int DemengeMax { get; set; }
        private int DemengeMin { get; set; }
        Random random = new Random();

        public MiliteryUnit(int health, string? name, int _demengemax, int _demengemin) : base(health, name)
        {
            DemengeMax = _demengemax;
            DemengeMin = _demengemin;
        }
        private int damenge;
        public int Demenge
        {
           
        }
      
    }
}
