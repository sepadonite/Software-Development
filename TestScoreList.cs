using System;
using System.Linq;
using static System.Console;
using System.Collections.Generic;
class TestScoreList
{
   static void Main()
   {
       var list = new List <int>();
       for(int x = 0; x < 8; x++)
       {
         list.Add(int.Parse(ReadLine()));
       }
       var avg = list.Average();
       for (int x = 0; x < 8; x++)
       {
         WriteLine($"Test # {x}: {list[x]} From average: {list[x] - avg}");
       }
   }
}
