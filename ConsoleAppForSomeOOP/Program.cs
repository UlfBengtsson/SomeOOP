using SomeOOP.Models;
using System;

namespace ConsoleAppForSomeOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Brand saab = new Brand();
            saab.Name = "Volvo";

            Car car = new Car(Guid.NewGuid(), "V70", saab);

            Console.WriteLine(car.Info());

            Brand volvo = new Brand();
            volvo.Name = "Volvo";

            Car anotherCar = new Car(Guid.NewGuid(), "740", volvo, "Gray");
            anotherCar.RegPlate = "CBA321";

            Console.WriteLine(anotherCar.Info());
        }
    }
}
