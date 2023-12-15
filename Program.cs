using System;

namespace TileCostCalculator // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            const double LABOUR_RATE = 86.00;
            const int SQUARE_METERS_PER_HOUR = 20;
            double area = 0;
            double flooringCost;
            double labourCost;
            double costPerUnit;
            int shape;

            Console.WriteLine("**** Tile Cost Calculator ****");
            Console.WriteLine("Enter 1 for a Rectangle Room");
            Console.WriteLine("Enter 2 for a Triangle Room");
            Console.Write(": ");

            shape = Convert.ToInt32(Console.ReadLine());

            if(shape < 1 | shape > 2)
            {
                Console.WriteLine("Invalid Shape");
                return;
            } 

            if(shape == 1)
            {
                Console.Write("Please enter the length of the rectangle in feet: ");
                double length = Convert.ToDouble(Console.ReadLine());
                Console.Write("Please enter the width of the rectangle in feet: ");
                double width = Convert.ToDouble(Console.ReadLine());
                area = length * width;
            }

            if(shape == 2)
            {  
                Console.Write("Please enter the base of the triangle in feet: ");
                double triangleBase = Convert.ToDouble(Console.ReadLine());
                Console.Write("Please enter the height of the triangle in feet: ");
                double height = Convert.ToDouble(Console.ReadLine());
                area = 0.5 * (triangleBase * height);
            }

            Console.Write("Please enter the cost per square foot: ");
            costPerUnit = Convert.ToDouble(Console.ReadLine());

            labourCost = area / SQUARE_METERS_PER_HOUR * LABOUR_RATE;
            flooringCost = area * costPerUnit;
            Console.WriteLine("----------------------------------");   
            Console.WriteLine($"Room Area: {area:.00} sq ft");
            Console.WriteLine($"Flooring Cost: {flooringCost:C}");
            Console.WriteLine($"Labour Cost: {labourCost:C}");
            Console.WriteLine($"Total Cost: {flooringCost + labourCost:C}");
            Console.Write("----------------------------------");    
        }
    }
}