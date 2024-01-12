using StrategyUnits;

Footman footman = new Footman();
Footman footman2 = new Footman();
Peasant ps1 = new Peasant();
Bishop bishop = new Bishop();

ps1.ShowInfo();
footman2.ShowInfo();
bishop.ShowInfo();
bishop.Healinghealth(ps1);
bishop.Healinghealth(ps1);
bishop.Healinghealth(ps1);
bishop.Healinghealth(ps1);
bishop.Healinghealth(ps1);
bishop.Healinghealth(ps1);
footman.InflictDamage(footman2);
bishop.Healinghealth(ps1); 
ps1.ShowInfo();
footman2.ShowInfo();
