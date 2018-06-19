using System;

namespace AbstractFactoryPattern
{
    public class SportsBike : IBike
    {
        public string Name()
        {
            return "This is sports bike";
        }
    }
}
