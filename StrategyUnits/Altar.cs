using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace StrategyUnits
{
    internal class Altar
    {
        private int _reserveofenergy;
        public int reserveofenergy
        {
            get { return _reserveofenergy; }
            set { _reserveofenergy = value; }
        }
        public Altar() 
        {
            reserveofenergy = 1000;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Reserve of energy: {_reserveofenergy} ");
        }
        public void RecoverOfEnergy(Bishop bishop)
        {
            bishop.Energy +=5;
            _reserveofenergy -= 5;
        }
    }
}
