// Hero yaroslav = new Hero("Ярослав", 100);
// Hero anastasia = new Hero("Анастасия", 90);
// Hero artem = new Hero("Артём", 120);
// Hero alexander = new Hero("   Александр   ", 150);

// alexander.TakeDamage(10);
// alexander.Heal(10);

// Console.WriteLine(">>> Участники готовы <<<");
// Console.WriteLine();
// Console.WriteLine(yaroslav.GetInfo());
// Console.WriteLine();
// Console.WriteLine(anastasia.GetInfo());
// Console.WriteLine();
// Console.WriteLine(artem.GetInfo());
// Console.WriteLine();
// Console.WriteLine(alexander.GetInfo());
// Console.WriteLine($"Предел здоровья Александра: {alexander.MaxHealth}");









/// >>>>>>>>>>>>>>>> Самостоятельная работа >>>>>>>>>>>>>>>> \\\

// Car bmw = new Car("BMW", "X5", 3.0, 2021, "Чёрный");
// Car lada = new Car("Lada", "Vesta", 1.6, 2019, "Белый");
// Car tesla = new Car("Tesla", "Model 3", 0.0, 2023, "Красный");

// Console.WriteLine(">>> Машина 1 <<<");
// Console.WriteLine($"Марка: {bmw.Brand}");
// Console.WriteLine($"Модель: {bmw.Model}");
// Console.WriteLine($"Год: {bmw.Year}");
// Console.WriteLine($"Цвет: {bmw.Color}");
// Console.WriteLine($"Объём двигателя: {bmw.EngineVolume}");
// Console.WriteLine($"Доступна: {bmw.IsAvailable}");

// Console.WriteLine();

// Console.WriteLine(">>> Машина 2 <<<");
// Console.WriteLine($"Марка: {lada.Brand}");
// Console.WriteLine($"Модель: {lada.Model}");
// Console.WriteLine($"Год: {lada.Year}");
// Console.WriteLine($"Цвет: {lada.Color}");
// Console.WriteLine($"Объём двигателя: {lada.EngineVolume}");
// Console.WriteLine($"Доступна: {lada.IsAvailable}");

// Console.WriteLine();

// Console.WriteLine(">>> Машина 3 <<<");
// Console.WriteLine($"Марка: {tesla.Brand}");
// Console.WriteLine($"Модель: {tesla.Model}");
// Console.WriteLine($"Год: {tesla.Year}");
// Console.WriteLine($"Цвет: {tesla.Color}");
// Console.WriteLine($"Объём двигателя: {tesla.EngineVolume}");
// Console.WriteLine($"Доступна: {tesla.IsAvailable}");

// Console.WriteLine(bmw.GetInfo());

// Console.WriteLine();

// Console.WriteLine($"Цвет БМВ до: {bmw.Color}");

// bmw.NewColor("Белый");
// Console.WriteLine($"Цвет БМВ после: {bmw.Color}");

// Console.WriteLine($"Пробег БМВ до: {bmw.Mileage}");

// bmw.AddMileage(50);

// Console.WriteLine($"Пробег БМВ после: {bmw.Mileage}");


Car gazelle = new Car("ГАЗ", "Газель", 2.8, 2019, "Белый", 1000);
Car kamaz   = new Car("КАМАЗ", "5490", 12.0, 2021, "Синий", -500);

Console.WriteLine(gazelle.GetInfo());
Console.WriteLine();
Console.WriteLine(kamaz.GetInfo());
Console.WriteLine();

gazelle.AddMileage(250);
gazelle.AddMileage(-100);

Console.WriteLine();
Console.WriteLine(gazelle.GetInfo());
Console.WriteLine($"Пробег КАМАЗа: {kamaz.Mileage}");

//gazelle.Mileage = 999; 