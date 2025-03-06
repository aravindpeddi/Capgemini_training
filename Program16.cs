//**Factory Pattern for Object Creation**

//Implement a `VehicleFactory` class that returns different vehicle objects
//(`Car`, `Bike`) based on an input parameter.

using System;

namespace c__Assignment
{
    abstract class Vehicle1
    {
        public abstract void Drive();
    }

    class Car1 : Vehicle1
    {
        public override void Drive()
        {
            Console.WriteLine("Driving a car.");
        }
    }

    class Bike1 : Vehicle1
    {
        public override void Drive()
        {
            Console.WriteLine("Riding a bike.");
        }
    }

    class VehicleFactory
    {
        public static Vehicle1 GetVehicle(string vehicleType)
        {
            switch (vehicleType.ToLower())
            {
                case "car":
                    return new Car1();
                case "bike":
                    return new Bike1();
                default:
                    throw new ArgumentException("Invalid vehicle type");
            }
        }
    }

    //class Program
    //{
    //    static void Main()
    //    {
    //        Vehicle1 car = VehicleFactory.GetVehicle("car");
    //        car.Drive();
    //        Vehicle1 bike = VehicleFactory.GetVehicle("bike");
    //        bike.Drive();
    //    }
    //}
}

