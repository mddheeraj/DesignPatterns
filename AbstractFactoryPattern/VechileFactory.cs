namespace AbstractFactoryPattern
{
    public interface VechileFactory
    {
        Bike GetBike(string bikeType);

        Car GetCar(string scooterType);
    }
}
