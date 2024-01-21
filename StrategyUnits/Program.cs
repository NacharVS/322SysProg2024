using StrategyUnits;

Footman footman = new Footman();
Footman footman2 = new Footman();
Peasant ps1 = new Peasant();
Bishop bishop1 = new Bishop();
Bishop bishop2 = new Bishop();
Altar altar1 = new Altar();
bishop1.HealthIncreasedEvent += GetIncreasedHealthEvent;
bishop1.HealthDecreasedEvent += GetDecreasedHealthEvent;

bishop1.ShowInfo();
footman.InflictDamage(bishop1);
footman.InflictDamage(bishop1);
bishop1.ShowInfo();
 static void GetIncreasedHealthEvent(int number) => Console.WriteLine($"Health has increased. Current {number}");
static void GetDecreasedHealthEvent(int number) => Console.WriteLine($"Health has decreased. Current {number}");

