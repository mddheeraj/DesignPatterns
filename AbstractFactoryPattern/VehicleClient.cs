namespace AbstractFactoryPattern
{
    public class VehicleClient
    {
        IBike bike;
        ICar car;

        public VehicleClient(IVechileFactory factory, string type)
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
