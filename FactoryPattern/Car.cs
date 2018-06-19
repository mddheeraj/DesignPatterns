using System;

namespace FactoryPattern
{
    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    public class Car : IFactory
    {
        public void Drive(int miles)
        {
            Console.WriteLine($"Drive the car for {miles} miles");
        }
    }
}
