using StrategyUnits;

Footman footman = new Footman();
Footman footman2 = new Footman();
Peasant ps1 = new Peasant();
Bishop bishop = new Bishop();
Church church = new Church();
Paladin paladin = new Paladin();

ps1.ShowInfo();
footman2.ShowInfo();
footman.ShowInfo();
bishop.ShowInfo();
paladin.ShowInfo();
church.ShowInfo();
Console.WriteLine();

footman.InflictDamage(ps1);
footman2.InflictDamage(paladin);
footman.InflictDamage(footman2);
footman.InflictDamage(footman2);
footman.InflictDamage(footman2);
footman.InflictDamage(footman2);
footman.InflictDamage(footman2);
footman.InflictDamage(footman2);
footman.InflictDamage(footman2);
footman.InflictDamage(footman2);
footman.InflictDamage(footman2);
ps1.ShowInfo();
footman2.ShowInfo();
footman.ShowInfo();
bishop.ShowInfo();
paladin.ShowInfo();
church.ShowInfo();
Console.WriteLine();

bishop.InFlickHill(ps1);
bishop.InFlickHill(footman2);
bishop.InFlickHill(paladin);
ps1.ShowInfo();
footman2.ShowInfo();
footman.ShowInfo();
bishop.ShowInfo();
paladin.ShowInfo();
church.ShowInfo();
Console.WriteLine();

footman2.InflictDamage(ps1);
paladin.SacredBlow(footman);
paladin.InflictDamage(bishop);
ps1.ShowInfo();
footman2.ShowInfo();
footman.ShowInfo();
bishop.ShowInfo();
paladin.ShowInfo();
church.ShowInfo();
Console.WriteLine();

church.EnergyRegen(bishop);
church.EnergyRegen(paladin);
ps1.ShowInfo();
footman2.ShowInfo();
footman.ShowInfo();
bishop.ShowInfo();
paladin.ShowInfo();
church.ShowInfo();
Console.WriteLine();
