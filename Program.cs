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
            double length;
            double width;
            int shape;

            Console.WriteLine("**** Tile Cost Calculator ****");
            Console.Write("Enter 1 for a Rectangle Room or 2 for a Triangle Room: ");
            shape = Convert.ToInt32(Console.ReadLine());

            if(shape < 1 | shape > 2)
            {
                Console.WriteLine("Invalid Shape");
                return;
            } 

            Console.Write("Please enter the length of the room in feet: ");
            length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter the width of the room in feet: ");
            width = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter the cost per square foot: ");
            costPerUnit = Convert.ToDouble(Console.ReadLine());

            if(shape == 1)
            {
                area = length * width;
            }

            if(shape == 2)
            {  
                area = 0.5 * (length * width);
            }

            labourCost = area / SQUARE_METERS_PER_HOUR * LABOUR_RATE;
            flooringCost = area * costPerUnit;
            Console.WriteLine("----------------------------------");   
            Console.WriteLine($"Room Area: {area} sq ft");
            Console.WriteLine($"Flooring Cost: ${flooringCost}");
            Console.WriteLine($"Labour Cost: ${labourCost}");
            Console.WriteLine($"Total Cost: ${flooringCost + labourCost}");
            Console.Write("----------------------------------");    
        }
    }
}