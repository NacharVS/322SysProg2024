using StrategyUnits;

Grunt gg = new Grunt();
Throll throll = new Throll();

gg.Attack(throll);
throll.Attack(gg);

Console.WriteLine(gg.Health);
Console.WriteLine(throll.Health);