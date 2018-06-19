using System.Collections.Generic;

namespace BuilderPattern
{
    public class Vehicle
    {
        //accessories, model, engine, transmission, body
        public List<string> Accessories { get; set; }
        public string Model { get; set; }
        public string Engine { get; set; }
        public string Transmission { get; set; }
        public string Body { get; set; }

        public Vehicle()
        {
            Accessories = new List<string>();
        }
    }
}
