using StrategyUnits;

barrack barrack = new barrack();
Footman footman = barrack.GetFootman(); 
Footman footman2 = barrack.CreateOfficer();
Peasant ps1 = new Peasant();
Peasant ps2 = new Peasant();
Bishop bishop = new Bishop();
Altar altar = new Altar();
ps1.ShowInfo();
ps2.ShowInfo();
footman2.ShowInfo();
bishop.ShowInfo();
Console.WriteLine();

footman.InflictDamage(ps1);
footman.InflictDamage(ps1);
footman.InflictDamage(ps1);
footman.InflictDamage(ps1);
footman.InflictDamage(ps1);

bishop.Hellping(ps1);


footman.InflictDamage(bishop);
footman.InflictDamage(ps2);
footman.InflictDamage(ps2);
footman.InflictDamage(ps2);
footman.InflictDamage(ps2);

bishop.Hellping(ps2);


bishop.Hellping(bishop);
altar.GetEnergy(bishop);
bishop.Hellping(bishop);

ps1.ShowInfo();
ps2.ShowInfo();
footman2.ShowInfo();
bishop.ShowInfo();