using StrategyUnits;

Footman footman = new Footman(100, "dsfsdf", 23, 45, 100);
Footman footman2 = new Footman(100, "dsfsdf", 23, 45, 100);
Peasant ps1 = new Peasant(100, "dsfsdf", 23);
Bishop bishop1 = new Bishop(100, "dsfsdf", 23, 45, 100, 200);
Bishop bishop2 = new Bishop(100, "dsfsdf", 23, 45, 100, 200);
Altar altar = new Altar(30);
Paladin palladin = new Paladin(100, "dsfsdf", 23, 45, 100, 200);

ps1.ShowInfo();
footman2.ShowInfo();
footman.InflictDamage(ps1);
footman.InflictDamage(footman2);
footman.InflictDamage(footman2);
ps1.ShowInfo();
footman2.ShowInfo();

ps1.ShowInfo();
footman2.ShowInfo();
bishop1.ShowInfo();
altar.RestoreEnergy(bishop1);
bishop1.ShowInfo();
palladin.SaintRow(bishop1);
palladin.ShowInfo();
bishop1.ShowInfo();