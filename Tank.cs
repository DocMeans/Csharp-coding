using System;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using static System.Console;


     /*
       Written by: Franklinm Means 3/22/2023

       This program is meant to take a users input for height and radius and calculate the suface area
       of the tank and return the values in square feet.

       When you run radius of 5 and a height of 5 you get:
       A ≈ 314.16
       I used the the .ToString method to only show two decimal points and it rounded the answer up from: A ≈ 314.15927
     */
namespace Tank_Franklin_Means
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input taken from the user for calculating the area of the tank.
            Write("Enter the Radius in feet: ");
            //converting the input string to a double
            double radius = double.Parse(ReadLine());

            Write("Enter the Height in feet: ");
            double height = double.Parse(ReadLine());

            //Passing the converted inputs from the user to be calculated in the AreaSquared method of the AreaSquared class
            Tank surfaceArea = new Tank(radius, height);

            // The outputs for the user to see what was calculated. 
            WriteLine("The surface area of the tank with a:");
            WriteLine("A radius of {0} feet", radius);
            WriteLine("A height of {0} feet", height);
            WriteLine("Totals {0} sqft", surfaceArea.Area().ToString("F2")); // .ToString("F2") is to show two decimal places rounded to the nearest hundreth.
        }
    }

    public class Tank
    {
        // Setting the variables
        private double height;
        private double radius;

        public Tank(double height, double radius)
        {
            // Importing the inputs from the user to be used in the class and methods
            this.height = height;
            this.radius = radius;
        }

        public double Area()
        {
            // The calculation for the suface area of the tank
            double PI = 3.141592;
            //equation used: A = 2πrh + 2πr^2
            return 2 * PI * radius * height + 2 * PI * radius * radius;
        }    // returns the finished calculation to the Main method for output
    }
}