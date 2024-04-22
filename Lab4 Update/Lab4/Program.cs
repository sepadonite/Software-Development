using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {

            //PART 2 - DO AFTER ObjectHolder.cs
            //Test Code - Modify to accept the relevant Generic Type


            //test for Int - should already succeed.
            ObjectHolder<int> intTest = new ObjectHolder<int>("Integer", 64);
            Console.WriteLine($"Int Test Results: Type Stored {intTest.WhatItsHolding} Value: {intTest.HeldValue}");
            //test for float - currently fails
            ObjectHolder<float> floatTest = new ObjectHolder<float>("Float", 64.5f);
            Console.WriteLine($"Int Test Results: Type Stored {floatTest.WhatItsHolding} Value: {floatTest.HeldValue}");
            //test for string - currently Fails
            ObjectHolder<string> stringTest = new ObjectHolder<string>("String", "This is indeed a string");
            Console.WriteLine($"Int Test Results: Type Stored {stringTest.WhatItsHolding} Value: {stringTest.HeldValue}");
            //test for Employee - currently Fails
            Employee michael = new Employee("Michael Doe");
            ObjectHolder<string> employeeTest = new ObjectHolder<string> ("Employee", "Michael");
            Console.WriteLine($"Int Test Results: Type Stored {employeeTest.WhatItsHolding} Value: {employeeTest.HeldValue}");
        }
    }
}
