using StrategyUnits;

Footman footman = new Footman();
Peasant ps1 = new Peasant();
Footman footman2 = new Footman();
Bishop bishop = new Bishop();
ps1.HealthIncreaseEvent += Method1;
ps1.HealthDecreaseEvent += Method2;
ps1.ShowInfo();
footman.InflictDamage(ps1);
footman.InflictDamage(ps1);
bishop.Heal(ps1);

static void Method1(double number)
{
    Console.WriteLine($"Health has Increased. Current {number}");
}
static void Method2(double number)
{
    Console.WriteLine($"Health has Decreased. Current {number}");
}
static void Method3(double number)
{
    Console.WriteLine($"Хахахахаха, не пробил!!! Current {number}");
}
static void Method4(double number)
{
    Console.WriteLine($"пробил!!! Current {number}");
}