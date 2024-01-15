using StrategyUnits;

Footman footman = new Footman();
Peasant ps1 = new Peasant();
Bishop bishop1 = new Bishop();
Paladin paladin = new Paladin();


footman.ShowInfo();
paladin.ShowInfo();
paladin.SaintTouch(footman);
paladin.SaintTouch(footman);
paladin.SaintTouch(footman);
footman.ShowInfo();
paladin.ShowInfo();
