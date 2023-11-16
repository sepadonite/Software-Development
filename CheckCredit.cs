using System;
using static System.Console;
class CheckCredit
{
   static void Main()
   {
      string creditPurchasePriceAsString;
      double purchased;
      WriteLine("Please enter price of item purchased on credit:");
      creditPurchasePriceAsString = ReadLine();
      purchased = Convert.ToDouble(creditPurchasePriceAsString);
      WriteLine((purchased > 8000)? "You have exceeded the credit limit":"Approved");
   }
}
