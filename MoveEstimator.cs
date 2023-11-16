using System;
using static System.Console;
using System.Globalization;
class MoveEstimator
{
 
   static void Main()
   {
     const double BASE_RATE = 200;
     const double PER_HOUR = 150;
     const double PER_MILE = 2;
      string perHoursAsString, perMilesAsString;
      double hours, miles;
      double estimate;
      Write("Enter number of hours");
      perHoursAsString = ReadLine();
      Write("Enter number of miles");
      perMilesAsString = ReadLine();
      hours = Convert.ToDouble(perHoursAsString);
      miles = Convert.ToDouble(perMilesAsString);
      estimate = (hours*PER_HOUR)+(miles*PER_MILE)+BASE_RATE;
      WriteLine("For a move taking {0} hours and going {1} miles the estimate is {2}", hours, miles, estimate.ToString("C", CultureInfo.GetCultureInfo("en-US")));
   }
}
