using System;
using System.Runtime.InteropServices.ComTypes;

namespace CalculateCircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a radius: ");
            double userInput = Double.Parse(Console.ReadLine());
            double area = Area.GetArea(userInput);
            double diameter = Diameter.GetDiameter(userInput);
            double circumference = Circumference.GetCircumference(userInput);
            Console.WriteLine("Area: " + area + " Diameter: " + diameter + " Circumference: " + circumference);

            Console.WriteLine("Enter your vehicle's MPG: ");
            int mpg = int.Parse(Console.ReadLine());
            double gasGallonsPerRotation = circumference / mpg;
            Console.WriteLine("Gallons of gas that will be used to go around this circle: " + gasGallonsPerRotation);
        }
    }
}
