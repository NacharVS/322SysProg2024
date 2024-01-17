using StrategyUnits;

Footman footman = new Footman();
Peasant ps1 = new Peasant();
Bishop bishop1 = new Bishop();

footman.ShowInfo();
footman.InflictDamage(footman);
bishop1.HealUnit(footman);

