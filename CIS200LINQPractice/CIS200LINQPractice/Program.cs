using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS200LINQPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice n1 = new Invoice(83, "Electric Sander", 7, 57.98m);
            Invoice n2 = new Invoice(24, "Power Saw", 18, 99.99m);
            Invoice n3 = new Invoice(7, "Sledge Hammer", 11, 21.50m);
            Invoice n4 = new Invoice(77, "Hammer",76, 11.99m);
            Invoice n5 = new Invoice(39, "Lawn Mower", 3, 79.50m);
            Invoice n6 = new Invoice(68, "Screwdriver", 106, 6.99m);
            Invoice n7 = new Invoice(56, "Jig saw", 21, 11.00m);
            Invoice n8 = new Invoice(3, "Wrench", 34, 7.50m);


            var linqList = new List<Invoice> { n1, n2, n3, n4, n5, n6, n7, n8 };

            //Sample - sorting by PartNumber
            Console.WriteLine("--------------Sample--------------------");
            var partSorted = from invoice in linqList
                             orderby invoice.PartNumber
                             select invoice;

            foreach (Invoice inv in partSorted)
            {
                Console.WriteLine(inv);
            }


            //a) use LINQ to sort the objects by PartDescription. 
            Console.WriteLine("--------------Part A--------------------");
            var partSortedDescription = from invoice in linqList
                             orderby invoice.PartDescription
                             select invoice;

            //b) use LINQ to sort the objects by Price
            Console.WriteLine("--------------Part B--------------------");
            var partSortedPrice = from invoice in linqList
                                  orderby invoice.Price
                                  select invoice;

            //c) use LINQ to select the PartDescription and Quantity. Sort the results by Quantity
            Console.WriteLine("--------------Part C--------------------");
            var partSortedDescriptAndQuantity = from invoice in linqList
                                                orderby invoice.Quantity
                                                select new { invoice.PartDescription, invoice.Quantity };

            //d) use LINQ to select from each invoice the PartDescription and value of the invoice (Quantity * Price). Name the calculated column 
            //  InvoiceTotal. Order the results by InvoiceTotal. (Hint - use let)
            Console.WriteLine("--------------Part D--------------------");
            var partSortedInvoiceTotal = from invoice in linqList
                                         let invoiceTotal = invoice.Quantity * invoice.Price
                                         orderby invoiceTotal
                                         select new { invoice.PartDescription, invoiceTotal };

            //e) Use the results from d to select InvoiceTotals in the range of $200 to $500
            Console.WriteLine("--------------Part E--------------------");
            var partSortedInvoiceTotalRange = from invoiceTotal in partSortedInvoiceTotal
                                              where invoiceTotal < 500 && invoiceTotal > 200
                                              orderby invoiceTotal ascending
                                              select invoiceTotal;


        }
    }
}
