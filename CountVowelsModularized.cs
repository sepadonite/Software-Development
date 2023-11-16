using System;
using System.Linq;
using static System.Console;
class CountVowelsModularized
{
   public static void Main()
   {
    WriteLine(CountVowels(ReadLine()));
   }
   public static int CountVowels(string phrase)
   {
    var z = new[] {'a', 'e', 'i', 'o', 'u'};
    return phrase.ToLower().Count(c => z.Contains(c));
   }
}
