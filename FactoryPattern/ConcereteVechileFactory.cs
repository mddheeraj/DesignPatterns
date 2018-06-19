using System;

namespace FactoryPattern
{
    public class ConcereteVechileFactory : VechileFactory
    {
        public override IFactory GetVechile(string vechileType)
        {
            switch (vechileType)
            {
                case "Car" :
                    return new Car();
                case "Bike":
                    return new Bike();
                default:
                    throw new ApplicationException($"Vechile {vechileType} cannot be created");
            }
        }
    }
}
