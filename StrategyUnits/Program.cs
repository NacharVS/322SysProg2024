using StrategyUnits;

Barracs barracs = new Barracs();
Footman footman = barracs.CreateOfficer();

Footman footman2 = barracs.CreateFootman();

footman.InflictDamage(footman2);
footman2.ShowInfo();
footman2.InflictDamage(footman);


footman.ShowInfo();

static void Method1(int number)
{
    Console.WriteLine($"Health has changed. Current {number}");
}

static void Method2(int number)
{
    Console.WriteLine($"Hqwertqwetrqwergfdfgsdfg. Current {number}");
}