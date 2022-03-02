using SomeOOP.Models;
using System;
using System.Linq;

namespace ConsoleAppForSomeOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exampel();
            string[] names = new string[] { "Ulf", "Kent", "Jonas" };

            PrintNames(names);

            //names = names.Append("Sven").ToArray();//Linq way to incress size and add name last in the array
            AddNameToArray(ref names, "Ola");

            PrintNames(names);
        }

        static void PrintNames(String[] stringArray)
        {
            foreach (String name in stringArray)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("--------------------------------");
        }

        static void AddNameToArray(ref String[] namesArray, string name)
        {
            IncressSizeOfArray(ref namesArray);
            namesArray[namesArray.Length - 1] = name;
        }

        static void IncressSizeOfArray(ref String[] stringArray)
        {
            Array.Resize(ref stringArray, stringArray.Length + 1);
        }

        static void Exampel()
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
