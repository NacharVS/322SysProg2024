using StrategyUnits;

Footman footman = new Footman();
Footman footman2 = new Footman();
Peasant ps1 = new Peasant();
Bishop bishop = new Bishop();
bishop.ShowInfo();

ps1.ShowInfo();
footman2.ShowInfo();
footman.InflictedDamage(ps1);
footman.InflictedDamage(footman2);
footman2.ShowInfo();
footman.InflictedDamage(footman2);
footman2.ShowInfo();
footman.InflictedDamage(footman2);
footman.InflictedDamage(ps1);
ps1.ShowInfo();
footman2.ShowInfo();
footman2.ShowInfo();
footman.InflictedDamage(ps1);
ps1.ShowInfo();

bishop.Heal(footman2);
bishop.Heal(ps1);

footman2.ShowInfo();
ps1.ShowInfo();
Console.WriteLine("У " + bishop + " осталось "+bishop.EnergyPoints + " энергии.");
Sanctuary sanctuary = new Sanctuary();
sanctuary.refill(bishop);
Console.WriteLine("У " + bishop.Name + " осталось " + bishop.EnergyPoints + " энергии.");
Console.WriteLine("У " + "Алтаря" + " осталось " + sanctuary.energyReserve + " энергии.");
////
footman.OnHealthLoss += Method1;
static void Method1(int number)
{
    Console.WriteLine($"Слабенько! {number}");
}

