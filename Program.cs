using System;

namespace TileCostCalculator // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            const double LABOUR_RATE = 86.00;
            const int SQUARE_METERS_PER_HOUR = 20;
            const int USER_CHOICE_RECTANGLE = 1;
            const int USER_CHOICE_TRIANGLE = 2;
            const int USER_CHOICE_CIRCLE = 3;
            double area = 0;
            double flooringCost;
            double labourCost;
            double costPerUnit;
            int shape;

            Console.WriteLine("**** Tile Cost Calculator ****");
            Console.WriteLine("Enter 1 for a Rectangle Room");
            Console.WriteLine("Enter 2 for a Triangle Room");
            Console.WriteLine("Enter 3 for a Circle Room");
            Console.Write(": ");

            shape = Convert.ToInt32(Console.ReadLine());

            if(shape < USER_CHOICE_RECTANGLE | shape > USER_CHOICE_CIRCLE)
            {
                Console.WriteLine("Invalid Input: Please enter 1, 2, or 3");
                return;
            } 

            if(shape == USER_CHOICE_RECTANGLE)
            {
                Console.Write("Please enter the length of the rectangle in feet: ");
                double length = Convert.ToDouble(Console.ReadLine());
                Console.Write("Please enter the width of the rectangle in feet: ");
                double width = Convert.ToDouble(Console.ReadLine());
                area = length * width;
            }

            if(shape == USER_CHOICE_TRIANGLE)
            {  
                Console.Write("Please enter the base of the triangle in feet: ");
                double triangleBase = Convert.ToDouble(Console.ReadLine());
                Console.Write("Please enter the height of the triangle in feet: ");
                double height = Convert.ToDouble(Console.ReadLine());
                area = 0.5 * (triangleBase * height);
            }

            if(shape == USER_CHOICE_CIRCLE)
            {  
                Console.Write("Please enter the radius of the circle in feet: ");
                double radius = Convert.ToDouble(Console.ReadLine());
                area = (radius * radius) *  Math.PI;
            }

            Console.Write("Please enter the cost per square foot: ");
            costPerUnit = Convert.ToDouble(Console.ReadLine());

            if(costPerUnit < 0){
                Console.WriteLine("Invalid Input: Cost per square foot cannot be a negative number");
                return;
            }

            labourCost = area / SQUARE_METERS_PER_HOUR * LABOUR_RATE;
            flooringCost = area * costPerUnit;
            Console.WriteLine("----------------------------------");   
            Console.WriteLine($"Room Area: {area:.00} sq ft");
            Console.WriteLine($"Flooring Cost: {flooringCost:C}");
            Console.WriteLine($"Labour Cost: {labourCost:C}");
            Console.WriteLine($"Total Cost: {flooringCost + labourCost:C}");
            Console.WriteLine("----------------------------------"); 
            Console.WriteLine("Press Enter to Exit");
            Console.ReadLine();   
        }
    }
}