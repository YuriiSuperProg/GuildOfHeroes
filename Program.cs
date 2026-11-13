//Probe.Run();

Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);
Hero alexander = new Hero("   Александр   ", 150);
Hero sergey = new Hero("Сергей", 110);

alexander.TakeDamage(10);
alexander.Heal(10);

Console.WriteLine($"Предел здоровья Александра: {alexander.MaxHealth}");

Guild guild = new Guild("Гильдия героев");

guild.AddHero(yaroslav);
guild.AddHero(anastasia);
guild.AddHero(artem);
guild.AddHero(alexander);
guild.AddHero(sergey);

List<Hero> members = guild.GetMembers();


Console.WriteLine($">>> {guild.Name}: перекличка <<<");
Console.WriteLine($"Участников: {guild.MemberCount}");

if (members.Count > 0) {
    Console.WriteLine($"Первый: {members[0].Name}");
    Console.WriteLine($"Последний: {members[members.Count - 1].Name}");
}
Console.WriteLine();
foreach (Hero hero in members) {
    Console.WriteLine(hero.GetInfo());
    Console.WriteLine();
}

Console.WriteLine($"Могут нести тяжёлые ящики (здоровье от 120): {guild.CountHealthy(120)}");

Hero? strongest = guild.FindStrongest();
if (strongest != null) {
    Console.WriteLine($"Самый здоровый: {strongest.Name} ({strongest.Health})");
}

Hero? found = guild.FindHeroByName(" аРтЁм ");
if (found != null) {
    Console.WriteLine($"Найден по запросу « аРтЁм »: {found.Name}");
} else {
    Console.WriteLine("По запросу « аРтЁм » никого нет.");
}

Console.WriteLine($"Повтор Александра принят: {guild.AddHero(alexander)}");

Console.WriteLine($"Удалён отсутствующий: {guild.RemoveHero("Борис")}");
Console.WriteLine($"Участников после проверок: {guild.MemberCount}");




/// >>>>>>>>>>>>>>>> Самостоятельная работа >>>>>>>>>>>>>>>> \\\

// Car bmw     = new Car("BMW", "X5", 3.0, 2021, "Чёрный", 0);
// Car lada    = new Car("Lada", "Vesta", 1.6, 2019, "Белый", 0);
// Car tesla   = new Car("Tesla", "Model 3", 0.0, 2023, "Красный", 0);
// Car hellcat = new Car("Dodge", "Challenger SRT Hellcat", 6.2, 2023, "Чёрный", 0);
// List<Car> cars = new List<Car>();
// cars.Add(bmw);
// cars.Add(lada);
// cars.Add(tesla);
// cars.Add(hellcat);

// Console.WriteLine($">>> Автопарк: в списке {cars.Count} машины <<<");
// if (cars.Count > 0) {
//     Console.WriteLine($"Первая: {cars[0].Brand} {cars[0].Model}");
//     Console.WriteLine($"Последняя: {cars[cars.Count - 1].Brand} {cars[ cars.Count - 1].Model}");
// }

// Console.WriteLine();

// foreach (Car car in cars) {
//     Console.WriteLine(car.GetInfo());
//     Console.WriteLine();
// }

// Car kamaz = new Car("КАМАЗ", "5490", 12.0, 2021, "Синий", 0);
// cars.Add(kamaz);
// Console.WriteLine($"После добавления: {cars.Count}");
// Console.WriteLine();

// int powerfulCount = 0;
// foreach (Car car in cars) {
//     if (car.EngineVolume > 2.0) {
//         powerfulCount++;
//     }
// }
// Console.WriteLine($"Машин с объёмом двигателя больше 2.0 л: {powerfulCount}");
// Console.WriteLine();

// Console.WriteLine($"Цвет BMW до: {cars[0].Color}");
// bmw.NewColor("Белый");
// Console.WriteLine($"Цвет BMW после (через переменную): {bmw.Color}");
// Console.WriteLine($"Цвет BMW после (через список): {cars[0].Color}");

// ================== Автопарк ==================

// Car bmw = new Car("BMW", "X5", 3.0, 2021, "Чёрный", 0);
// Car lada = new Car("Lada", "Vesta", 1.6, 2019, "Белый", 0);
// Car tesla = new Car("Tesla", "Model 3", 0.0, 2023, "Красный", 0);
// Car hellcat = new Car("Dodge", "Challenger SRT Hellcat", 6.2, 2023, "Чёрный", 0);

// List<Car> cars = new List<Car>();
// cars.Add(bmw);
// cars.Add(lada);
// cars.Add(tesla);
// cars.Add(hellcat);

// Console.WriteLine($">>> Автопарк: в списке {cars.Count} машины <<<");
// if (cars.Count > 0) {
//     Console.WriteLine($"Первая: {cars[0].Brand} {cars[0].Model}");
//     Console.WriteLine($"Последняя: {cars[cars.Count - 1].Brand} {cars[cars.Count - 1].Model}");
// }

// Console.WriteLine();

// foreach (Car car in cars) {
//     Console.WriteLine(car.GetInfo());
//     Console.WriteLine();
// }

// Car kamaz = new Car("КАМАЗ", "5490", 12.0, 2021, "Синий", 0);
// cars.Add(kamaz);
// Console.WriteLine($"После добавления: {cars.Count}");
// Console.WriteLine();

// int powerfulCount = 0;
// foreach (Car car in cars) {
//     if (car.EngineVolume > 2.0) {
//         powerfulCount++;
//     }
// }
// Console.WriteLine($"Машин с объёмом двигателя больше 2.0 л: {powerfulCount}");
// Console.WriteLine();

// Console.WriteLine($"Цвет BMW до: {cars[0].Color}");
// bmw.NewColor("Белый");
// Console.WriteLine($"Цвет BMW после (через переменную): {bmw.Color}");
// Console.WriteLine($"Цвет BMW после (через список): {cars[0].Color}");
// Console.WriteLine();

// Garage garage = new Garage("Основной гараж");

// Car bmw2  = new Car("BMW", "X5", 3.0, 2021, "Чёрный", 0);
// Car lada2 = new Car("Lada", "Vesta", 1.6, 2019, "Белый", 0);
// Car hell2 = new Car("Dodge", "Challenger SRT Hellcat", 6.2, 2023, "Чёрный", 0);

// Console.WriteLine(garage.AddCar(bmw2));
// Console.WriteLine(garage.AddCar(lada2));
// Console.WriteLine(garage.AddCar(hell2));

// Car bmwDup = new Car("BMW", "  x5  ", 3.0, 2022, "Красный", 0);
// Console.WriteLine(garage.AddCar(bmwDup));

// Car? foundCar = garage.FindByModel("  X5 ");
// Console.WriteLine(foundCar != null);
// Car? missingCar = garage.FindByModel("Audi");
// Console.WriteLine(missingCar == null);

// Console.WriteLine(garage.Count);

// Console.WriteLine(garage.RemoveByModel("lada vesta"));
// Console.WriteLine(garage.RemoveByModel("Lada Vesta"));

// Console.WriteLine(garage.Count);

// Console.WriteLine(garage.CountByEngineAtLeast(3.0));