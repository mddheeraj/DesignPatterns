using System;

namespace DecoratorPattern
{
    /// <summary>
    /// The 'ConcreteDecorator' class
    /// </summary>
    public class SpecialOffer : VehicleDecorator
    {
        public SpecialOffer(IVehicle vehicle) : base(vehicle) { }

        public int DiscountPercentage { get; set; }
        public string Offer { get; set; }

        //public new double Price
        public double Price
        {
            get
            {
                double price = base.Price;
                int percentage = 100 - DiscountPercentage;
                return Math.Round((price * percentage) / 100, 2);
            }
        }

    }
}
