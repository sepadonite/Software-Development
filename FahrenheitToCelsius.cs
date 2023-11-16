using System;
using static System.Console;
class FahrenheitToCelsius
{
   static void Main()
   {
      double Fah;
      double Cel;
      string fahAsString;
      fahAsString = ReadLine();
      Fah = Convert. ToDouble(fahAsString);
      Cel=(Fah-32)*(5.0/9.0);
      WriteLine("{0} F is {1} C", Fah.ToString("F1"), Cel.ToString("F1"));
   }
}
