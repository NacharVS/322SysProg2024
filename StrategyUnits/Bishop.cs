namespace StrategyUnits
{
    internal class Bishop : MagicUnit
    {
        public Bishop(string name , int health, int minDamage , int maxDamage,int defence, int energy) : base(health, name, minDamage, maxDamage , defence, energy)//медик
        {
        }
        public void Hill(Unit unit)
        {
             if (Energy != 0 && unit.Alive != false)
            {
                if (unit.Health != unit.MaxHealth)
                {
                while (unit.Health < unit.MaxHealth && Energy > 0)
                    {
                        unit.Health++;
                        Energy -= 2;
                    }
                }
                else { Console.WriteLine("Unit Max HP"); }
            }
            else { Console.WriteLine("Cannot be hill"); }
            

        }

           public void Hill(Zectof unit)
        {

            if (Energy != 0 && unit.Alive != false && unit.ArmorOFFsithBool  == true)
            {
                if (unit.Health != unit.MaxHealth)
                {
                while (unit.Health < unit.MaxHealth && Energy > 0)
                {
                unit.Health++;
                Energy -= 2;
                }
                }
                else { Console.WriteLine("Unit Max HP"); }
            }
            else { Console.WriteLine("Cannot be hellping"); }
            

        }

    }
}
