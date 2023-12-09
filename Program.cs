using System;

namespace TileCostCalculator // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            const double LABOUR_RATE = 86.00;
            double flooringCost;
            double labourCost;
            string costPerUnit = "";
            double area = 0;
        
            Console.WriteLine("**** Tile Cost Calculator ****");
            Console.Write("Enter 1 for a Rectangle Room or 2 for a Triangle Room: ");
            string roomShape = Console.ReadLine();

            if(roomShape != "1" && roomShape != "2")
            {
                Console.Write("Invalid Input");
                return;
            }

            Console.Write("Please enter the length of the room in feet: ");
            string length = Console.ReadLine();
            Console.Write("Please enter the width of the room in feet: ");
            string width = Console.ReadLine();
            Console.Write("Please enter the cost per square foot: ");

            if(roomShape == "1")
            {
                costPerUnit = Console.ReadLine();
                area = Double.Parse(length) * Double.Parse(width);
            }

            if(roomShape == "2")
            {
                costPerUnit = Console.ReadLine();
                //Length is equivalent to base and width is equivalent to height
                area = 0.5 * (Double.Parse(length) * Double.Parse(width));
            }

            labourCost = area / 20 * LABOUR_RATE;
            flooringCost = area * Double.Parse(costPerUnit);
            Console.WriteLine("----------------------------------");   
            Console.WriteLine($"Room Area: {area} sq ft");
            Console.WriteLine($"Flooring Cost: ${flooringCost}");
            Console.WriteLine($"Labour Cost: ${labourCost}");
            Console.WriteLine($"Total Cost: ${flooringCost + labourCost}");
            Console.Write("----------------------------------");    

        }
    }
}