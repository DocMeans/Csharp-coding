using System;
using System.Runtime.CompilerServices;
using static System.Console;
namespace Multiply_1 // Franklin Means 2/6/2023
{
    internal class Program
    { // This program when ran has the option to show just the multiplied numbers or the multiplies if desired.
        // uncomment line 18 and comment out line 16 to see the multipliers 
        static void Main()
        {
            // This loop run the x range
            for (int x = 1; x <= 10; x++)
            {   // This loop runs the y range of the table
                for (int y = 1; y <= 10; y++)
                {   // This is where you format how you want to output to look
                    Write("{0}\t", x * y);
                    
                    //Write("{0}x{1}={2}\t", y, x, x * y);  /* This one is formatted to look like*/
                                                              /*traditional multiplication tables.*/
                }
                WriteLine();
            }
            ReadLine();
            
        }
    }
}