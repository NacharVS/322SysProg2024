using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal class MilitaryUnit : Unit// войны
    {
        Random random = new Random();
        public MilitaryUnit(int health, string name, int minDamage, int maxDamage, int defence) : base(health, name, defence)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
        }

        public int MinDamage { get; }
        public int MaxDamage { get; }

        private int demage;

        public void InflictDamage(Unit unit, int percent)
        {
            if (unit.Alive == false) {
                return;
            }
            demage = unit.Defence - (random.Next(MinDamage - 1, MaxDamage) * percent / 100);
            unit.Health -= demage;
            Console.WriteLine($"Damage {demage} hp to {unit.Name}");


        }

        public void InflictDamage(Unit unit)
        {
            if (unit.Alive == false){ 
                return;
                }
            demage = unit.Defence - random.Next(MinDamage - 1, MaxDamage);
            unit.Health -= demage;
            Console.WriteLine($"Damage {demage} hp to {unit.Name}");
        }


        public override void ShowInfo()
        {

            Console.WriteLine($"Unit: {Name} Health: {Health} Alive: {Alive} Min demage: {MinDamage} Max demage: {MaxDamage} Defence: {Defence} ");
        }
    }
}
