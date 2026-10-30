/// >>>>>>>>>>>>>>>> Самостоятельная работа >>>>>>>>>>>>>>>> \\\

class Car {
    public string Brand;
    public string Model;

    public  double EngineVolume;
    public int Year;
    public string Color;
    public bool IsAvailable;

    public Car(string brand, string model, double engineVolume, int year, string color) {
        Brand = brand;
        EngineVolume = engineVolume;
        Model = model;
        Year = year;
        Color = color;
        IsAvailable = true;
    }
}