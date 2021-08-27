using System;

namespace ClassesExercise
{
    class Program
    {
        public class Car
        {
            public Car(string make, string model, int year)
            {
                Console.WriteLine($"the make is {make} the model is {model} and the year is {year} of this car.");
            }
               
        }


        static void Main(string[] args)
        {
            Console.WriteLine("what is the make of the car");
            string make = Console.ReadLine();
            Console.WriteLine("what is the make of the car");
            string model = Console.ReadLine();
            Console.WriteLine("what is the make of the car");
            int year = Convert.ToInt32(Console.ReadLine());
            object car1 = new Car(make, model, year);
        }
    }
}
