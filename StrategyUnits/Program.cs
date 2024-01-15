using StrategyUnits;

Footman footman = new Footman();
Footman footman2 = new Footman();
Peasant ps1 = new Peasant();
Bishop bishop = new Bishop();

ps1.ShowInfo();
footman.ShowInfo();
bishop.ShowInfo();
bishop.InfoEnergy();
Console.WriteLine();

footman.InflictDamage(ps1);
footman.InflictDamage(ps1);
footman.InflictDamage(ps1);
//ps1.Health += 100;
ps1.ShowInfo();
Console.WriteLine();

bishop.Treatment(ps1);
ps1.ShowInfo();
footman2.ShowInfo();