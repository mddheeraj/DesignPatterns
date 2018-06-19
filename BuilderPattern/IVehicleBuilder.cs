namespace BuilderPattern
{
    public interface IVehicleBuilder
    {
        void SetModel();
        void SetEngine();
        void SetTransmission();
        void SetAccessories();
        void SetBody();
        Vehicle GetVehicle();
    }
}
