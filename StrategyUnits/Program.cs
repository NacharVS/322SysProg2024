using StrategyUnits;
Barrac barrac = new Barrac();
Footman footman = barrac.CreateOfficer();

Footman footman2 = barrac.CreateFootman();

footman.InflictDamage(footman2);
footman2.ShowInfo();
footman2.InflictDamage(footman);

Footman footman4 = new Footman();
Footman footman3 = new Footman();
Peasant ps1 = new Peasant();
Bishop bishop1 = new Bishop();
Bishop bishop2 = new Bishop();
Paladin paladin = new Paladin();

ps1.ShowInfo();
footman2.ShowInfo();
footman.InflictDamage(ps1);
footman.InflictDamage(footman2);
footman.InflictDamage(footman2);
ps1.ShowInfo();
footman2.ShowInfo();
bishop1.InflictHeal(ps1);
bishop2.InflictHeal(footman2);
ps1.ShowInfo();
footman2.ShowInfo();
bishop1.ShowInfo();
Altar altar = new Altar();
bishop1.InflictHeal(footman2);
bishop1.ShowInfo();
altar.BishopAltar(bishop1);
bishop1.ShowInfo();
paladin.SaintRow(bishop1);
paladin.ShowInfo();