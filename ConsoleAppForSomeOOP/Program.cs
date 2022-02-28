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
            saab.Name = "SAAB";

            Car car = new Car(Guid.NewGuid(), "900", saab);

            Console.WriteLine(car.Info());

            Brand volvo = new Brand();
            volvo.Name = "Volvo";

            Car anotherCar = new Car(Guid.NewGuid(), "740", volvo, "Gray");
            anotherCar.RegPlate = "ABC321";

            Console.WriteLine(anotherCar.Info());
        }
    }
}
