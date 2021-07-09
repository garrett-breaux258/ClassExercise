using System;
using System.Collections.Generic;   

namespace ClassExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            car.Make = "Ford";
            car.Model = "Mustang";
            car.Year = 2017;

            var Cars = new List<Car>();
            Cars.Add(car);

            Console.WriteLine("Make  Model  Year");
            Console.WriteLine("-----------------");

            foreach (var item in Cars)
            {
                Console.WriteLine($"{item.Make} {item.Model} {item.Year}");
            }

        }
    }
}
