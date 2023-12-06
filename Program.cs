using System;

namespace TileCostCalculator // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string costPerUnit;
            double flooringCost;
            double labourCost;
            double area;
            double labourRate = 86.00;

            Console.WriteLine("**** Tile Cost Calculator ****");
            Console.Write("Please enter the length of the room in feet: ");
            string length = Console.ReadLine();
            Console.Write("Please enter the width of the room in feet: ");
            string width = Console.ReadLine();
            Console.Write("Please enter the cost per square foot: ");
            costPerUnit = Console.ReadLine();
            
            area = Double.Parse(length) * Double.Parse(width);
            labourCost = area * labourRate;
            flooringCost = area * Double.Parse(costPerUnit); 
              
            Console.WriteLine($"Room Area: {area} sq ft");
            Console.WriteLine($"Flooring Cost: ${flooringCost}");
            Console.WriteLine($"Labour Cost: ${labourCost}");
            Console.WriteLine($"Total Cost: ${flooringCost + labourCost}"); 

        }
    }
}