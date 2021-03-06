﻿using AbstractFactoryPattern;
using AdapterPattern;
using BridgePattern;
using BuilderPattern;
using CompositePattern;
using DecoratorPattern;
using FactoryPattern;
using PrototypePattern;
using SingletonPattern;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing Factory Pattern (Creational Design Pattern)");
            TestFactoryPattern();
            Console.WriteLine();
            Console.WriteLine("Testing Abstract Factory Pattern (Creational Design Pattern)");
            TestAbstractFactoryPattern();
            Console.WriteLine();
            Console.WriteLine("Testing Builder Pattern (Creational Design Pattern)");
            TestBuilderPattern();
            Console.WriteLine();
            Console.WriteLine("Testing Prototype Pattern (Creational Design Pattern)");
            TestPrototypePattern();
            Console.WriteLine();
            Console.WriteLine("Testing Singleton Pattern (Creational Design Pattern)");
            TestSingletonPattern();
            Console.WriteLine();
            Console.WriteLine("Testing Adapter Pattern (Structural Design Pattern)");
            TestAdapterPattern();
            Console.WriteLine();
            Console.WriteLine("Testing Bridge Pattern (Structural Design Pattern)");
            TestBridgePattern();
            Console.WriteLine();
            Console.WriteLine("Testing Composite Pattern (Structural Design Pattern)");
            TestCompositePattern();
            Console.WriteLine();
            Console.WriteLine("Testing Decorator Pattern (Structural Design Pattern)");
            TestDecoratorPattern();
            Console.ReadLine();
        }

        #region Creation Design Patterns Implementation

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

        static void TestSingletonPattern()
        {
            Singleton.Instance.Show();
            Singleton.Instance.Show();
        }

        #endregion

        #region Structural Design Patterns Implementation

        static void TestAdapterPattern()
        {
            ITarget itarget = new EmployeeAdapter();
            ThirdPartyBillingSystem thirdPartyBillingSystem = new ThirdPartyBillingSystem(itarget);
            thirdPartyBillingSystem.ShowEmployeeList();
        }

        static void TestBridgePattern()
        {
            IMessageSender emailSender = new EmailSender();
            IMessageSender msmqSender = new MSMQSender();

            Message systemMessage = new SystemMessage();
            systemMessage.Body = "System Message";
            systemMessage.Subject = "Message from system";
            systemMessage.MessageSender = emailSender;
            systemMessage.Send();

            UserMessage userMessage = new UserMessage();
            userMessage.Body = "User Message";
            userMessage.Subject = "Message from user";
            userMessage.UserComments = "User comments";
            userMessage.MessageSender = msmqSender;
            userMessage.Send();
        }

        static void TestCompositePattern()
        {
            Employee Rahul = new Employee { EmpID = 1, Name = "Rahul" };

            Employee Amit = new Employee { EmpID = 2, Name = "Amit" };
            Employee Mohan = new Employee { EmpID = 3, Name = "Mohan" };

            Rahul.AddSubordinate(Amit);
            Rahul.AddSubordinate(Mohan);

            Employee Rita = new Employee { EmpID = 4, Name = "Rita" };
            Employee Hari = new Employee { EmpID = 5, Name = "Hari" };

            Amit.AddSubordinate(Rita);
            Amit.AddSubordinate(Hari);

            Employee Kamal = new Employee { EmpID = 6, Name = "Kamal" };
            Employee Raj = new Employee { EmpID = 7, Name = "Raj" };

            Contractor Sam = new Contractor { EmpID = 8, Name = "Sam" };
            Contractor tim = new Contractor { EmpID = 9, Name = "Tim" };

            Mohan.AddSubordinate(Kamal);
            Mohan.AddSubordinate(Raj);
            Mohan.AddSubordinate(Sam);
            Mohan.AddSubordinate(tim);

            Console.WriteLine("EmpID={0}, Name={1}", Rahul.EmpID, Rahul.Name);

            foreach (Employee manager in Rahul)
            {
                Console.WriteLine("\n EmpID={0}, Name={1}", manager.EmpID, manager.Name);

                foreach (var employee in manager)
                {
                    Console.WriteLine(" \t EmpID={0}, Name={1}", employee.EmpID, employee.Name);
                }
            }
        }

        static void TestDecoratorPattern()
        {
            // Basic vehicle
            HondaCity car = new HondaCity();

            Console.WriteLine("Honda City base price are : {0}", car.Price);

            // Special offer
            SpecialOffer offer = new SpecialOffer(car);
            offer.DiscountPercentage = 25;
            offer.Offer = "25 % discount";

            Console.WriteLine("{1} @ Independence Day Special Offer and price are : {0} ", offer.Price, offer.Offer);
        }

        #endregion
    }
}
