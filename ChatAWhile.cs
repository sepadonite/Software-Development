using System;
using System.Collections.Generic;
using static System.Console;
using System.Globalization;
class ChatAWhile
{
   static void Main()
   {
      var dict = new Dictionary <string, double>()
      {
        {"262",	0.07},
        {"414",	0.10},
        {"608",	0.05},
        {"715",	0.16},
        {"815",	0.24},
        {"920",	0.14}
      };
      var area = ReadLine();
      if (dict.ContainsKey(area))
      {
        var rate = int.Parse(ReadLine());
        WriteLine($"Your phone call to area {area} costs {dict[area].ToString("C")} per minute. For {rate} minutes the total is {(rate * dict[area]).ToString()}");
      }
      else
        WriteLine ($"Sorry - no calls allowed to area {area}");
   }
}
