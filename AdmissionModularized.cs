using System;
using static System.Console;
class AdmissionModularized
{
   static void Main()
   {
      double gpa;
      int testScore;
      
      WriteLine("Enter grade point average ");
      gpa = Convert.ToDouble(ReadLine());
      WriteLine("Enter test score ");
      testScore = Convert.ToInt32(ReadLine());
      AcceptOrReject(gpa, testScore);
   }

    public static string AcceptOrReject(double gpa, int testScore)
   {
       const double MIN_GPA = 3.0; // added an underscore to MINGPA to improve readability
       const int ADMIN1 = 60, ADMIN2 = 80;
       string ruling = " ";

      if(gpa >= MIN_GPA)
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
