Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);
Hero alexander = new Hero("Александр", 150);

Console.WriteLine(yaroslav.GetInfo());
Console.WriteLine();
Console.WriteLine(anastasia.GetInfo());
Console.WriteLine();
Console.WriteLine(artem.GetInfo());
Console.WriteLine();
Console.WriteLine(alexander.GetInfo());




Hero lowProbe = new Hero("Проверка нижней границы", -100);
Hero highProbe = new Hero("Проверка верхней границы", 5000);
Console.WriteLine($"Нижняя граница: {lowProbe.Health}/{lowProbe.MaxHealth}");
Console.WriteLine($"Верхняя граница: {highProbe.Health}/{highProbe.MaxHealth}");
Console.WriteLine($"Александр до действий: {alexander.Health}/{alexander.MaxHealth}");

alexander.TakeDamage(30);
alexander.Heal(10);
Console.WriteLine($"Обычные действия: {alexander.Health}");
alexander.Heal(5000);
Console.WriteLine($"Большое лечение: {alexander.Health}");
alexander.Heal(-20);
Console.WriteLine($"Отказ в лечении: {alexander.Health}");
alexander.TakeDamage(5000);
Console.WriteLine($"Большой урон: {alexander.Health}; жив: {alexander.IsAlive()}");
alexander.Heal(20);
Console.WriteLine($"Восстановление: {alexander.Health}");
Console.WriteLine($"Артём без изменений: {artem.Health}/{artem.MaxHealth}");














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