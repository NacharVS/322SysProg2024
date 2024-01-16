using StrategyUnits;

Footman footman = new Footman();
Footman footman2 = new Footman();
Peasant ps1 = new Peasant();
Bishop bishop1 = new Bishop();
Bishop bishop2 = new Bishop();
Altar altar = new Altar(30);
Palladin palladin = new Palladin();

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
altar.RestoreEnergy(bishop1);
bishop1.ShowInfo();
palladin.SaintRow(bishop1);
palladin.ShowInfo();
bishop1.ShowInfo();


