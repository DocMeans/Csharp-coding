using System.Globalization;
using static System.Console;
namespace Paint.Estimate.Franklin.Means
{
    /* Written by: Franklin Means 2/19/2023
      This program estimates the price of a painting service based 
      on the total square feet of the walls to be painted.
      Gather size data from the user for the calculations.
      Find the square feet measurement by calculating the users inputs.
      Use the square feet total and the constant to calculate the total price.
      output the total square feet and the total price of the painting estimate.
     */
    internal class Program
    {   // Constants
        const int WALL_HEIGHT = 9;
        const int PRICE_PER_SQUARE_FOOT = 6;
       
        static void Main()
        {
            WriteLine("Enter wall sizes for price");
            WallArea();
        }
       
        public static void WallArea()
        {
            // Variables
            int squareFoot, wallLength, wallWidth, totalPrice;

            // User inputs
            Write("Enter the length of one of the long walls: ");
            wallLength = Convert.ToInt32(ReadLine());
            Write("Enter the width of one of the short walls: ");
            wallWidth = Convert.ToInt32(ReadLine());

            // Calculations for the total square feet and the total price.
            squareFoot = (2 * wallLength * WALL_HEIGHT) + (2 * wallWidth * WALL_HEIGHT);
            totalPrice = squareFoot * PRICE_PER_SQUARE_FOOT;

            // Output the totals and a conversion added to the price to show the currency symbol for the USD.
            WriteLine("For {0} Square feet of wall space it will cost {1} to paint", squareFoot, totalPrice.ToString("C", CultureInfo.GetCultureInfo("en-US")));
        }
    }
}