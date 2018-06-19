using System;

namespace FactoryPattern
{
    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    public class Bike : IFactory
    {
        public void Drive(int miles)
        {
            Console.WriteLine($"Drive the Bike for {miles} miles.");
        }
    }
}
