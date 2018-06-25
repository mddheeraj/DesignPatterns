﻿using AbstractFactoryPattern;
using BuilderPattern;
using FactoryPattern;
using PrototypePattern;
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
            Console.WriteLine("Testing Builder Pattern");
            TestBuilderPattern();
            Console.WriteLine("Testing Prototype Pattern");
            TestPrototypePattern();
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

        static void TestBuilderPattern()
        {
            IVehicleBuilder builder = new HondaVehicle();
            VehicleCreator creator = new VehicleCreator(builder);
            creator.CreateVehicle();
            Vehicle vech = creator.GetVehicle();
            Console.WriteLine(vech.Model);
            Console.WriteLine(vech.Body);
            Console.WriteLine(vech.Engine);
            Console.WriteLine(vech.Transmission);
            foreach(string acce in vech.Accessories)
            {
                Console.WriteLine(acce);
            }
        }

        static void TestPrototypePattern()
        {
            Developer dev = new Developer();
            dev.Name = "Rahul";
            dev.Role = "Team Leader";
            dev.PreferredLanguage = "C#";

            Developer devCopy = (Developer)dev.Clone();
            devCopy.Name = "Arif"; //Not mention Role and PreferredLanguage, it will copy above

            Console.WriteLine(dev.GetDetails());
            Console.WriteLine(devCopy.GetDetails());

            Typist typist = new Typist();
            typist.Name = "Monu";
            typist.Role = "Typist";
            typist.WordsPerMinute = 120;

            Typist typistCopy = (Typist)typist.Clone();
            typistCopy.Name = "Sahil";
            typistCopy.WordsPerMinute = 115;//Not mention Role, it will copy above

            Console.WriteLine(typist.GetDetails());
            Console.WriteLine(typistCopy.GetDetails());
        }
    }
}