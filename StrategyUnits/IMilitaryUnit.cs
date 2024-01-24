using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal interface IMilitaryUnit
    {
        public int MaxDamage { get; set; }
        public int MinDamage { get; set; }

        public void InflictDamage(IHealController unit);



        //public void InflictDamage(Unit unit)
        /// <summary>
        /// {
        /// </summary>


            //double damage = CountDamage();
            //unit.GetDamage(damage);


        //}

      //  public virtual double CountDamage()
        //{
          //  return random.Next(MinDamage, MaxDamage);
        //}
    }
}
