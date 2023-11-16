using System;
using static System.Console;
class MakeChange
{
   static void Main()
   {
     int dollars, twenties, tens, fives, ones;
      dollars= int.Parse(ReadLine());
    twenties = dollars/ 20;
    dollars = dollars% 20;
    tens = dollars/ 10;
    dollars = dollars% 10;
    fives =dollars/ 5;
    ones = dollars% 5;
     WriteLine($"twenties: {twenties} tens: {tens} fives: {fives} ones: {ones}");
}
}
