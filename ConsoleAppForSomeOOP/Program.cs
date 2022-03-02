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

            PrintArray(names);

            //names = names.Append("Sven").ToArray();//Linq way to incress size and add name last in the array
            AddToArray(ref names, "Ola");

            PrintArray(names);

            int[] numbers = new int[] { 1, 2, 3 };

            PrintArray(numbers);

            AddToArray(ref numbers, 4);

            PrintArray(numbers);
        }

        static void PrintArray<T>(T[] stringArray)
        {
            foreach (var name in stringArray)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("--------------------------------");
        }

        static void AddToArray<T>(ref T[] array, T toAdd)
        {
            IncressSizeOfArray(ref array);
            array[array.Length - 1] = toAdd;
        }

        static void IncressSizeOfArray<T>(ref T[] array)
        {
            Array.Resize(ref array, array.Length + 1);
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
