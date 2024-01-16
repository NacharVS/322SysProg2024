using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MilitaryUnit:Unit
    {
        private int _mindamage;
        private int _maxdamage;

        public int MaxDamage {  get { return _maxdamage; } set {  _maxdamage = value; } }
        public int Mindamage { get { return _mindamage; } set { _mindamage = value; } }
        public int Damage;

        public MilitaryUnit(int health, string? name, bool life,int defence, int maxddamage, int mindamage) : base(health, name, life, defence)
        {
            int rewrite;
            if (maxddamage<mindamage)
            {
                rewrite = maxddamage;
                maxddamage = mindamage;
                mindamage = rewrite;
            }
            _maxdamage = maxddamage;
            _mindamage = mindamage;
            Damage = GetRandomDamage(mindamage, maxddamage );
        }

        public int GetRandomDamage(int min, int max)
        {
            Random r = new Random();
            return Convert.ToInt32(r.Next(min, max));
        }
    }
}
