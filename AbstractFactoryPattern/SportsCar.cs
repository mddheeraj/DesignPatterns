using System;

namespace AbstractFactoryPattern
{
    public class SportsCar : ICar
    {
        public string Name()
        {
            return "This is sports car";
        }
    }
}
