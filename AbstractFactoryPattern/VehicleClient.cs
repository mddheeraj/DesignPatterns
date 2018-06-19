namespace AbstractFactoryPattern
{
    public class VehicleClient
    {
        Bike bike;
        Car car;

        public VehicleClient(VechileFactory factory, string type)
        {
            bike = factory.GetBike(type);
            car = factory.GetCar(type);
        }

        public string GetBikeName()
        {
            return bike.Name();
        }

        public string GetCarName()
        {
            return car.Name();
        }
    }
}
