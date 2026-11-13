public class Car {
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

public class Garage {
    private List<Car> _cars = new List<Car>();

    public string Name { get; private set; }

    public int Count {
        get { return _cars.Count; }
    }

    public Garage(string name) {
        Name = name;
    }

    public bool AddCar(Car car) {
        if (car == null) {
            return false;
        }
        if (FindByModel(car.Model) != null) {
            return false;
        }
        _cars.Add(car);
        return true;
    }

    public Car? FindByModel(string model) {
        if (string.IsNullOrWhiteSpace(model)) {
            return null;
        }

        string search = model.Trim();

        foreach (Car car in _cars) {
            if (string.Equals(car.Model, search, StringComparison.OrdinalIgnoreCase)) {
                return car;
            }
        }

        return null;
    }

    public bool RemoveByModel(string model) {
        Car? car = FindByModel(model);
        if (car == null) {
            return false;
        }
        return _cars.Remove(car);
    }

    public List<Car> GetCars() {
        return new List<Car>(_cars);
    }

    public int CountByEngineAtLeast(double minVolume) {
        int count = 0;
        foreach (Car car in _cars) {
            if (car.EngineVolume >= minVolume) {
                count++;
            }
        }
        return count;
    }
}