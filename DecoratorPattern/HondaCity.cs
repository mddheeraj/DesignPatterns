namespace DecoratorPattern
{
    /// <summary>
    /// The 'ConcreteComponent' class
    /// </summary>
    public class HondaCity : IVehicle
    {
        public string Make
        {
            get
            {
                return "Honda";
            }
        }

        public string Model
        {
            get
            {
                return "Honda city";
            }
        }

        public double Price
        {
            get
            {
                return 25000.0;
            }
        }
    }
}
