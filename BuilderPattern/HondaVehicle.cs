namespace BuilderPattern
{
    public class HondaVehicle : IVehicleBuilder
    {
        Vehicle vechObj = new Vehicle();

        public Vehicle GetVehicle()
        {
            return vechObj;
        }

        public void SetAccessories()
        {
            vechObj.Accessories.Add("Mirrors");
        }

        public void SetBody()
        {
            vechObj.Body = "plastic";
        }

        public void SetEngine()
        {
            vechObj.Engine = "v4";
        }

        public void SetModel()
        {
            vechObj.Model = "test";
        }

        public void SetTransmission()
        {
            vechObj.Transmission = "test transmission";
        }
    }
}
