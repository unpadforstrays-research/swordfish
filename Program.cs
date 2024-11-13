using System;
using FelineBmiCalculator.Models;
using FelineBmiCalculator.Services;

namespace FelineBmiCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueRunning = true;

            while (continueRunning)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Feline BMI Calculator!");

                Console.Write("Enter the name of your cat: ");
                string name = Console.ReadLine();

                Console.Write("Enter the weight of your cat (in kg): ");
                double weight;
                while (!double.TryParse(Console.ReadLine(), out weight) || weight <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a positive number for the weight.");
                }

                Console.Write("Enter the length of your cat (in cm): ");
                double length;
                while (!double.TryParse(Console.ReadLine(), out length) || length <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a positive number for the length.");
                }

                Cat cat = new Cat(name, weight, length);
                double bmi = BmiCalculator.CalculateBmi(cat);

                Console.WriteLine($"\n{name}'s BMI is {bmi:F2}");

                Console.WriteLine("\nWould you like to calculate another BMI? (y/n): ");
                string response = Console.ReadLine().ToLower();

                if (response != "y")
                {
                    continueRunning = false;
                }
            }

            Console.WriteLine("Thank you for using the Feline BMI Calculator. Goodbye!");
        }
    }
}