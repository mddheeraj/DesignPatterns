namespace AbstractFactoryPattern
{
    public interface IVechileFactory
    {
        IBike GetBike(string bikeType);

        ICar GetCar(string scooterType);
    }
}
