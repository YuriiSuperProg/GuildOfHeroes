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

guild.Heroes.Add(yaroslav);
guild.Heroes.Add(anastasia);

guild.Heroes.Add(artem);
guild.Heroes.Add(alexander);
guild.Heroes.Add(sergey);

Console.WriteLine($">>> {guild.Name}: перекличка <<<");
Console.WriteLine($"Участников: {guild.Heroes.Count}");

if (guild.Heroes.Count > 0) {
    Console.WriteLine($"Первый: {guild.Heroes[0].Name}");
    Console.WriteLine($"Последний: {guild.Heroes[guild.Heroes.Count - 1].Name}");
}
Console.WriteLine();
foreach (Hero hero in guild.Heroes) {
    Console.WriteLine(hero.GetInfo());
    Console.WriteLine();
}

int strongCount = 0;

foreach(Hero hero in guild.Heroes) {
    if (hero.Health >= 120) {
        strongCount++;
    }
}
Console.WriteLine($"Могут нести тяжёлые ящики (здоровье от 120): {strongCount}");

if (guild.Heroes.Count > 0) {
    Hero strongest = guild.Heroes[0];
    foreach (Hero hero in guild.Heroes) {
        if (hero.Health > strongest.Health) {
            strongest = hero;
        }
    }
    Console.WriteLine($"Самый здоровый: {strongest.Name} ({strongest.Health})");
}







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