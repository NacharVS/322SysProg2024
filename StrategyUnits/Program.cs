using StrategyUnits;

Footman footman = new Footman();
Footman footman2 = new Footman();
Peasant ps1 = new Peasant();
Bishop bishop = new Bishop();

ps1.ShowInfo();
footman2.ShowInfo();
Console.WriteLine();

footman.InflictDamage(ps1);
footman.InflictDamage(footman2);
footman.InflictDamage(footman2);
footman.InflictDamage(footman2);
footman.InflictDamage(footman2);
footman.InflictDamage(footman2);
footman.InflictDamage(footman2);
footman.InflictDamage(footman2);
footman.InflictDamage(footman2);
footman.InflictDamage(footman2);
footman.InflictDamage(footman2);
footman.InflictDamage(footman2);
ps1.ShowInfo();
footman2.ShowInfo();
Console.WriteLine();

bishop.InFlickHill(ps1);
bishop.InFlickHill(footman2);
ps1.ShowInfo();
footman2.ShowInfo();