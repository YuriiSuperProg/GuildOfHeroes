class Car {
    public string Brand;
    public string Model;
    public double EngineVolume;
    public int Year;
    public int Mileage { get; private set; }
    public string Color;
    public bool IsAvailable;

    public Car(string brand, string model, double engineVolume, int year, string color, int mileage) {
        Brand = brand;
        Model = model;
        EngineVolume = engineVolume;
        Year = year;
        Color = color;
        IsAvailable = true;
        Mileage = mileage;
        if (Mileage < 0) {
            Mileage = 0;
        }
    }

    public void NewColor(string newColor) {
        if (Color == newColor) {
            Console.WriteLine($"[Отказ] Машина уже имеет {newColor} цвет!");
            return;
        }

        Color = newColor;
        Console.WriteLine($"Успешно! Машина перекрашена в {newColor} цвет.");
    }

    public void AddMileage(int km) {
        if (km <= 0) {
            Console.WriteLine("[Отказ] Пробег должен быть положительным.");
            return;
        }

        Mileage += km;
        Console.WriteLine($"Пробег увеличен на {km} км. Теперь: {Mileage} км.");
    }

    public string GetInfo() {
        return 
        $"Марка: {Brand}\n" 
        + $"Модель: {Model}\n" 
        + $"Объем двигателя: {EngineVolume}\n" 
        + $"Пробег: {Mileage}\n" 
        + $"Год выпуска: {Year}\n"
        + $"Цвет: {Color}\n"
        + $"Доступна: {IsAvailable}";
    }
}