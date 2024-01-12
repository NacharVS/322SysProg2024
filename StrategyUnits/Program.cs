using StrategyUnits;

Footman footman = new Footman();
Footman footman2 = new Footman();
Peasant ps1 = new Peasant();
Bishop bishop1 = new Bishop();
Bishop bishop2 = new Bishop();


bishop1.ShowInfo();
footman.InflictDamage(bishop1);
footman.InflictDamage(bishop1);
bishop1.ShowInfo();
bishop1.GetHealth(bishop2, bishop1);
bishop2.GetHealth(bishop1, bishop2);
bishop1.ShowInfo();
bishop2.ShowInfo();
//ps1.ShowInfo();
//footman2.ShowInfo();

//footman.InflictDamage(footman2);
//ps1.ShowInfo();
//footman2.ShowInfo();
//footman2.ShowInfo();