// Hero yaroslav = new Hero("Ярослав", 100);
// Hero anastasia = new Hero("Анастасия", 90);
// Hero artem = new Hero("Артём", 120);
// Hero margarita = new Hero("Маргарита", 80);

// Console.WriteLine(">>> Герой 1 <<<");
// Console.WriteLine($"Имя: {yaroslav.Name}");
// Console.WriteLine($"Здоровье: {yaroslav.Health}");
// Console.WriteLine($"Уровень: {yaroslav.Level}");
// Console.WriteLine($"Опыт: {yaroslav.Experience}");

// Console.WriteLine();

// Console.WriteLine(">>> Герой 2 <<<");
// Console.WriteLine($"Имя: {anastasia.Name}");
// Console.WriteLine($"Здоровье: {anastasia.Health}");
// Console.WriteLine($"Уровень: {anastasia.Level}");
// Console.WriteLine($"Опыт: {anastasia.Experience}");

// Console.WriteLine();

// Console.WriteLine(">>> Герой 3 <<<");
// Console.WriteLine($"Имя: {artem.Name}");
// Console.WriteLine($"Здоровье: {artem.Health}");
// Console.WriteLine($"Уровень: {artem.Level}");
// Console.WriteLine($"Опыт: {artem.Experience}");

// Console.WriteLine($"До вызовов: {yaroslav.Health}, {anastasia.Health}, {artem.Health}");

// yaroslav.TakeDamage(25);
// anastasia.TakeDamage(30);

// Console.WriteLine($"После вызовов: {yaroslav.Health}, {anastasia.Health}, {artem.Health}");

// yaroslav.TakeDamage(-20);
// Console.WriteLine($"После неверного урона: {yaroslav.Health}");

// artem.TakeDamage(200);
// Console.WriteLine($"После сильного урона, Артём: {artem.Health}");


// yaroslav.Heal(10);
// yaroslav.GainExperience(40);
// yaroslav.GainExperience(25);

// Console.WriteLine($"После лечения, Ярослав: {yaroslav.Health}");
// Console.WriteLine($"Опыт Ярослава: {yaroslav.Experience}");

// bool yaroslavAlive = yaroslav.IsAlive();
// Console.WriteLine($"Ярослав жив: {yaroslavAlive}");
// Console.WriteLine($"Артём жив: {artem.IsAlive()}");

// if (yaroslavAlive) {
//     Console.WriteLine("Ярослав может продолжать приключение.");
// } else {
//     Console.WriteLine("Ярослав больше не может сражаться.");
// }

// string info = yaroslav.GetInfo();
// Console.WriteLine("Строка получена. Сейчас выведем её:");
// Console.WriteLine(info);

// Console.WriteLine();
// Console.WriteLine(anastasia.GetInfo());
// Console.WriteLine();
// Console.WriteLine(artem.GetInfo());

/// >>>>>>>>>>>>>>>> Самостоятельная работа >>>>>>>>>>>>>>>> \\\

Car bmw = new Car("BMW", "X5", 3.0, 2021, "Чёрный");
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

Console.WriteLine(bmw.GetInfo());

Console.WriteLine();

Console.WriteLine($"Цвет БМВ до: {bmw.Color}");

bmw.NewColor("Белый");
Console.WriteLine($"Цвет БМВ после: {bmw.Color}");

Console.WriteLine($"Пробег БМВ до: {bmw.Mileage}");

bmw.AddMileage(50);

Console.WriteLine($"Пробег БМВ после: {bmw.Mileage}");