using StrategyUnits;

  
            // Создаем юнитов
            Peasant ps1 = new Peasant(100, "Peasant1", 10);
            Footman footman = new Footman(120, "Footman", 10, 20, 15);
            Footman footman2 = new Footman(110, "Footman2", 8, 18, 12);

            // Выводим информацию о юнитах
            ps1.ShowInfo();
            footman.ShowInfo();
            footman2.ShowInfo();

            // Наносим урон юнитам
            footman.InflictedDamage(ps1);
            footman.InflictedDamage(footman2);

            // Выводим информацию о юнитах после получения урона
            ps1.ShowInfo();
            footman.ShowInfo();
            footman2.ShowInfo();

            // Проверяем работу метода Frenzy у Berserk
            Berserk berserk = new Berserk(200, "Berserk", 15, 25, 20);
            berserk.Frenzy();

            // Выводим информацию о Berserk после Frenzy
            berserk.ShowInfo();

            // Создаем бараки и создаем офицера
            Barracs barracs = new Barracs();
            Footman officer = barracs.CreateOfficer();

            // Выводим информацию об офицере
            officer.ShowInfo();

            // Создаем священника
            Bishop bishop = new Bishop(150, "Bishop", 10, 20, 15);

            // Вызываем метод Heal у священника
            bishop.Heal(footman);

            // Выводим информацию об офицере после лечения
            footman.ShowInfo();

            // Создаем зелота
            Zeclot zeclot = new Zeclot(120, "Zeclot", 15, 30, 18);

            // Вызываем метод ArmorOfFaiths у зелота
            zeclot.ArmorOfFaiths(90);

            // Выводим информацию о зелоте
            zeclot.ShowInfo();

            // Создаем священника и вызываем событие HealEvent
            Bishop anotherBishop = new Bishop(200, "AnotherBishop", 12, 25, 20);
            anotherBishop.HealEvent += (mana, health, bishopName, unitName) =>
            {
                Console.WriteLine($"{bishopName} вылечил {unitName} на {mana} маны. Теперь здоровье: {health}");
            };
            anotherBishop.Heal(footman);

            // Проверяем работу метода Frenzy у Berserk после вызова события HealEvent
            berserk.Frenzy();
            berserk.ShowInfo();
// Проверяем метод Rage у Berserk
Footman footmans = new Footman(120, "Footman", 10, 20, 15);
Berserk enemyBer = barracs.CreateBerserk();


// Выводим информацию о юнитах

enemyBer.ShowInfo();
// Вызываем метод Rage у Footman
footmans.Rage(enemyBer);

// Выводим информацию о юните после Rage
enemyBer.ShowInfo();
//это делегаты!

Footman myFootman = new Footman(120, "MyFootman", 10, 20, 15);
Palladin myPalladin = new Palladin(150, "MyPalladin", 15, 25, 20);

myFootman.OnHealthIncreased += (health) => Console.WriteLine($"Здоровье Footman увеличено до {health}.");
myFootman.OnHealthDecreased += (health) => Console.WriteLine($"Здоровье Footman уменьшено до {health}.");

myPalladin.OnHealthIncreased += (health) => Console.WriteLine($"Здоровье Palladin увеличено до {health}.");
myPalladin.OnHealthDecreased += (health) => Console.WriteLine($"Здоровье Palladin уменьшено до {health}.");

myFootman.ShowInfo();
myPalladin.ShowInfo();

myFootman.Rage(myPalladin);

myFootman.ShowInfo();
myPalladin.ShowInfo();

//Barracs barracs = new Barracs();
//Footman footman = barracs.CreateOfficer();
//Footman footman = new Footman();
//Footman footman2 = new Footman();
//Peasant ps1 = new Peasant();
//Bishop bishop = new Bishop();
//bishop.ShowInfo();

//ps1.ShowInfo();
//footman2.ShowInfo();
//footman.InflictedDamage(ps1);
//footman.InflictedDamage(footman2);
//footman2.ShowInfo();
//footman.InflictedDamage(footman2);
//footman2.ShowInfo();
//footman.InflictedDamage(footman2);
//footman.InflictedDamage(ps1);
//ps1.ShowInfo();
//footman2.ShowInfo();
//footman2.ShowInfo();
//footman.InflictedDamage(ps1);
//ps1.ShowInfo();

//bishop.Heal(footman2);
//bishop.Heal(ps1);

//footman2.ShowInfo();
//ps1.ShowInfo();
//Console.WriteLine("У " + bishop + " осталось "+bishop.EnergyPoints + " энергии.");
//Sanctuary sanctuary = new Sanctuary();
//sanctuary.refill(bishop);
//Console.WriteLine("У " + bishop.Name + " осталось " + bishop.EnergyPoints + " энергии.");
//Console.WriteLine("У " + "Алтаря" + " осталось " + sanctuary.energyReserve + " энергии.");
//////
//footman.OnHealthLoss += Method1;
//static void Method1(int number)
//{
//    Console.WriteLine($"Слабенько! {number}");
//}

