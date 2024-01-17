using StrategyUnits;

Footman footman = new Footman();
Peasant ps1 = new Peasant();
Footman footman2 = new Footman();
footman2.HealthChangedEvent += Method1;
ps1.HealthChangedEvent += Method1;
ps1.ShowInfo();
footman.InflictDamage(ps1);
footman.InflictDamage(footman2);
footman.InflictDamage(footman2);
footman.InflictDamage(footman2);

footman2.ShowInfo();

static void Method1(int number)
{
    Console.WriteLine($"Health has changed. Current {number}");
}

static void Method2(int number)
{
    Console.WriteLine($"Hqwertqwetrqwergfdfgsdfg. Current {number}");
}