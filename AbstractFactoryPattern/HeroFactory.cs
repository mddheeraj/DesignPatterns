﻿using System;

namespace AbstractFactoryPattern
{
    public class HeroFactory : IVechileFactory
    {
        public IBike GetBike(string bikeType)
        {
            switch(bikeType)
            {
                case "Regular" :
                    return new RegularBike();
                case "Sports":
                    return new SportsBike();
                default:
                    throw new ApplicationException($"This bike {bikeType} cannot be created");
            }
        }

        public ICar GetCar(string carType)
        {
            switch(carType)
            {
                case "Regular":
                    return new RegularCar();
                case "Sports":
                    return new SportsCar();
                default:
                    throw new ApplicationException($"This car {carType} cannot be created");
            }
        }
    }
}
