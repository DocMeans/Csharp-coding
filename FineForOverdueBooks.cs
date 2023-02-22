using System;
using static System.Console;
using System.Globalization;
public class FineForOverdueBooks
{
   public static void Main()
   {
     int books;
     int days;
    // Write your main here.
    Write("Number of books due: ");
    books = Convert.ToInt32(ReadLine());
    Write("Number of days overdue: ");
    days = Convert.ToInt32(ReadLine());
    DisplayFine(books, days);
    

   }
   public static double DisplayFine(int books, int days)
   {
    // Write your DisplayFine method here.
      double firstSevenDays = 0.1;
      double additionalDays = 0.2;
      double fine = 0;
      if(days <= 7)
      {
        fine = books * days * firstSevenDays;
      }
      else if(days > 7)
      { 
        int sevenDays = 7;
        fine = (books * sevenDays * firstSevenDays) + (books * (days - 7) * additionalDays);
      }
      WriteLine("The fine for {0} book(s) for {1} day(s) is {2}", books, days, fine.ToString("C", CultureInfo.GetCultureInfo("en-US")));
      return fine;
   }
}
