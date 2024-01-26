using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal interface IHealthController
    {
        
        public int Health { get; set; }
        public void TakeDamage(int damage);

        public void TakeHeal(int healAmount);
        public int MaxHealth { get;  set; }
        public bool IsAlive { get => Health > 0; }
        public virtual void GetHeal(int healAmount)
        {
            if (healAmount > 0)
                Health += healAmount;
        }
        public int MaxMana
        {
            get;
             set;
        }

        public int mana
        {

            get
            {
                return _mana;
            }
            set
            {
                if (value < 0)
                {
                    _mana = 0;
                }
                else
                {
                    if (value > MaxMana)
                        _mana = MaxMana;
                    else
                        _mana = value;
                }
            }
        }
        public int RemovedMana { get => MaxMana - mana; }
        object Name { get; set; }
        byte RemovedHealth { get; }
    }
}
