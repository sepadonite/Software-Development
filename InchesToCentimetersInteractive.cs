using System;
using static System.Console;
class InchesToCentimetersInteractive
{
   static void Main()
   {
    
      const double CENTIMETERS_PER_INCH = 2.54;
      double inches = 3;
      inches = Convert.ToDouble(ReadLine());
      WriteLine("{0} inches is {1} centimeters", inches, inches * CENTIMETERS_PER_INCH); 
   }
}
