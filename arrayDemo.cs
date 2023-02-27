using System;
using static System.Console;
namespace ArrayDemo.Franklin.Means
{
     /* Written by: Franklin Means 2/19/2023
     This demo lets you choose to view the content in the array in original and in reverse order
     without changing the order permanently.*/

    internal class Program 
    {
        static void Main()
        {
            //Variables
            int userInput;
            int positionInput;
            // Loop for at least one iteration.
            do
            {   // Input from user to drive the loop.
                WriteLine("Enter 1 to view array");
                WriteLine("Enter 2 to view array in reversed order");
                WriteLine("Enter 3 to view any position in the array");
                Write("or 4 to quit: ");
                userInput = Convert.ToInt32(ReadLine());
                WriteLine();

                if (userInput == 1)
                {
                    // Local arrays in each option to prevent permanent change in the order.
                    int[] numbers = { 7, 6, 3, 2, 10, 8, 4, 5, 9, 1 };
                    // Loop through array until the end.
                    for (int arrayIndex = 0; arrayIndex < numbers.Length; ++arrayIndex)
                    {
                        // Output result of loop for user to inspect.
                        Write("{0}, ", numbers[arrayIndex]);
                    }
                    //Adds a seperation between the userInput and the output.
                    WriteLine();
                }

                else if (userInput == 2)
                {
                    int[] numbers = { 7, 6, 3, 2, 10, 8, 4, 5, 9, 1 };
                    //The reverse function will list the order of the array in reverse as listed.
                    Array.Reverse(numbers);
                    for (int arrayIndex = 0; arrayIndex < numbers.Length; ++arrayIndex)
                    {
                        Write("{0}, ", numbers[arrayIndex]);
                    }
                    WriteLine();
                }

                else if (userInput == 3)
                { //This loop will show a specific array positions value.
                    Write("Choose a position 0-9 from the original array: ");
                    positionInput = Convert.ToInt32(ReadLine());

                    int[] numbers = { 7, 6, 3, 2, 10, 8, 4, 5, 9, 1 };
                    for (int arrayIndex = -1; arrayIndex <= positionInput; ++arrayIndex)
                    {
                        arrayIndex = positionInput;
                        WriteLine("{0}", numbers.GetValue(positionInput));
                    }
                    WriteLine();
                }
                //The loop ends upon the user entering the number 4.
            } while (userInput != 4);
        }
    }
}