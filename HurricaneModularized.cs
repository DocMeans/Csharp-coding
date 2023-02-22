using System;
using static System.Console;
class HurricaneModularized
{
   static void Main()
   {    
    // Write your main here.
    int windSpd;
     
    Write("Windspeed: ");
    windSpd = Convert.ToInt32(ReadLine());
    GetCategory(windSpd);
   }

    public static int GetCategory(int windSpd)
   {
    // Write your GetCategory method here.
    int cat = 0;

    if(windSpd <= 73)
     {
        WriteLine("This is not a hurricane");
     }
      else if(windSpd >= 74 && windSpd <= 95)
     {
       cat = 1;
       WriteLine("This is a category {0} hurricane", cat);
     }
     else if(windSpd >= 96 && windSpd <= 110)
     {
       cat = 2;
       WriteLine("This is a category {0} hurricane", cat);
     }
     else if(windSpd >= 111 && windSpd <= 129)
     {
       cat = 3;
       WriteLine("This is a category {0} hurricane", cat);
     }
     else if(windSpd >= 130 && windSpd <= 156)
     {
       cat = 4;
       WriteLine("This is a category {0} hurricane", cat);
     }
     else if(windSpd >=157)
     {
       cat = 5;
       WriteLine("This is a category {0} hurricane", cat);
     }
     
     switch(cat)
     {
       case 1:
       WriteLine("One");
       break;
       case 2:
       WriteLine("Two");
       break;
       case 3:
       WriteLine("Three");
       break;
       case 4:
       WriteLine("Four");
       break;
       case 5:
       WriteLine("Five");
       break;
     }
    return cat;
   }
}
