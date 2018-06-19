using AbstractFactoryPattern;
using FactoryPattern;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing Factory Pattern");
            TestFactoryPattern();
            Console.WriteLine("Testing Abstract Factory Pattern");
            TestAbstractFactoryPattern();
            Console.ReadLine();
        }

        static void TestFactoryPattern()
        {
            FactoryPattern.VechileFactory factory = new ConcereteVechileFactory();

            IFactory bikeVechile = factory.GetVechile("Bike");
            bikeVechile.Drive(20);

            IFactory carVechile = factory.GetVechile("Car");
            carVechile.Drive(20);

            try
            {

                IFactory truckVechile = factory.GetVechile("Truck");
                truckVechile.Drive(20);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void TestAbstractFactoryPattern()
        {
            HeroFactory heroFactory = new HeroFactory();

            VehicleClient client = new VehicleClient(heroFactory, "Sports");
            Console.WriteLine(client.GetBikeName());
            Console.WriteLine(client.GetCarName());

            client = new VehicleClient(heroFactory, "Regular");
            Console.WriteLine(client.GetBikeName());
            Console.WriteLine(client.GetCarName());
        }
    }
}
