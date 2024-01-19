using StrategyUnits;

barrack barrack = new barrack();
Footman footman = barrack.GetFootman(); 
Footman footman2 = barrack.CreateOfficer();
Palladin pl = barrack.CreateDwarf();
Peasant ps1 = new Peasant();
Peasant ps2 = new Peasant();
Bishop bishop = new Bishop();
Altar altar = new Altar();
altar.Info();
pl.ShowInfo();
ps1.ShowInfo();
ps2.ShowInfo();
bishop.ShowInfo();
footman.ShowInfo();
footman2.ShowInfo();

pl.MagicDemage(footman2);

pl.MagicDemage(footman2);

pl.MagicDemage(footman2);

pl.MagicDemage(footman2);

pl.MagicDemage(footman2);

footman.InflictDamage(pl);
pl.Prayer();
footman2.InflictDamage(ps1);

