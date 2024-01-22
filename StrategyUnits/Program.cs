using StrategyUnits;

Footman footman = new Footman();
Footman footman2 = new Footman();
Peasant ps1 = new Peasant();
Bishop bishop = new Bishop();
Altar altar = new Altar();
footman.ShowInfo();
footman.InflictDamage(footman);
footman.InflictDamage(footman);
footman.InflictDamage(footman);
footman.ShowInfo();
bishop.Healinghealth(footman);
footman.ShowInfo();
bishop.ShowEnergy();

