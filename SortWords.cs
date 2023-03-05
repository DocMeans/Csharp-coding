using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using static System.Console;
namespace SortWord.Franklin.Means
{ // SortWord written by Franklin Means 3/05/2023
  // This program takes words that are input by the user and places them in a list which is converted to an array
  // then it is sorted and displayed
    internal class Program
    {
        public static void Main()
        {   //the array for strings set to 1 element
            string[] words = new string[0];
            // passing the array to the SortAndDisplay method
            SortAndDisplayWords(words);
        }

        public static void SortAndDisplayWords(params string[] words)
        {
            //Variables
            string inputWordStr;
            string quit = "";
            // a list to add muliple entries an array that is alreay predifined in size
            List<string> word = new(words);
           
            do  // this loop takes the input from the user and adds it to the list and will run until inputWordStr == quit
            {
                Write("Enter a word or press enter to quit: ");
                inputWordStr = ReadLine();

                if (inputWordStr != quit)
                {
                    word.Add(inputWordStr);
                }
            } while (inputWordStr != quit);
            WriteLine("\n");
            // this adds the list components to the array
            words = word.ToArray();
           
            WriteLine("Words in alphabetical order: ");
            // Array.Sort places the string elements in alphabetical order
            Array.Sort(words);
            // this loop runs through the array after it is sorted and prints the output to the console.
            for (int index = 0; index < words.Length; index++)
            {
                Write("{0} ", words[index]);
            } 
        }
    }
}