using System;
using static System.Console;
class ConvertMilesToKilometers
{
   static void Main()
   {
     // Write your main here.
     double miles;
     
     Write("Enter miles: ");
     miles = Convert.ToDouble(ReadLine());
     double kilometers = ConvertToKilometers(miles);
     WriteLine("{0} ", kilometers);
   }    

   public static double ConvertToKilometers(double miles)
   {
     // Write your ConvertToKilometers() method here.
     double kilometer = 1.60934;
     
     double kilometers = miles * kilometer;
     return kilometers;
   }
}
