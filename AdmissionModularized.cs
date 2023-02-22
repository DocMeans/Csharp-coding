using System;
using static System.Console;
class AdmissionModularized // note the name change in the instructions
{
   static void Main()
   {
      double gpa;
      int testScore;
      
      string inputString;
      WriteLine("Enter grade point average ");
      inputString = ReadLine();
      gpa = Convert.ToDouble(inputString);
      WriteLine("Enter test score ");
      inputString = ReadLine();
      testScore = Convert.ToInt32(inputString);
      AcceptOrReject(gpa, testScore);
      
   }
    public static string AcceptOrReject(double gpa, int testScore)
   {
    // Write your AcceptOrReject method here.
    const double MINGPA = 3.0;
    const int ADMIN1 = 60, ADMIN2 = 80;
    string ruling = " ";

      if(gpa >= MINGPA)
      {
         if(testScore >= ADMIN1)
         {
             ruling = "Accept";
         }
            
         else
         {
             ruling = "Reject";
         } 
      }
         
      else
      {
         if(testScore >= ADMIN2)
         {
             ruling = "Accept";
         }
            
         else
         {
             ruling = "Reject";
         }
      }
      WriteLine("{0}", ruling);
      return ruling;
   }
}
