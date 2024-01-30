

using System.Xml.Linq;

namespace StrategyUnits
{
    internal class Altar 
    {
        private int _mana = 5000;

        public int Mana { get { return _mana;} }
        public void GetEnergy(IMagicUnit magicUnit)//алтарь
        {

            while(magicUnit.Energy < magicUnit.MaxEnergy || _mana <0)
            {
                magicUnit.Energy++;
                _mana -= 10 ;
            }
            Console.WriteLine($"Mana left {_mana}");
        }
        public void Info()
        {

            Console.WriteLine($"Mana: {_mana} ");
        }
    }
}
