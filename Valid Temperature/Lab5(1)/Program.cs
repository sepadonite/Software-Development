//Lab3
//09.25.2022
//F2218
//CIS 199-50-4228
//This program allows a user to input a temperature within a specifc range.
//If not within the specific range the program will prompt the user to enter a valid input.
//When within the range the program will relay back the number of valid inputs and the mean temperature
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;// variable to count the number of valid inputs
            string inputTempAsString; // user input as string
            double inputTemp; // user input as double
            double sumTemp = 0; // the total of all valid temperature
            Console.WriteLine("Please enter valid temperature between -20 to 130 (999 to stop)");// prompt to enter temperature within range
            inputTempAsString = Console.ReadLine();// allows user to input the temperature
            while (999 != (inputTemp = double.Parse(Console.ReadLine())))// while statement stating the when the temperature is not 999 the inputTemp is Parsed to equal the users input (this is where 999 also exits the loop)
             if (inputTemp > -20 && inputTemp < 130)// setting the sspecific range
                {
                    sumTemp += inputTemp; count++;// sumTemp is equal to sumTemp + inputTemp, and a count increment
                    Console.WriteLine($" You have entered {count} valid temperatures");// displays the valid temperature input count
                    Console.WriteLine($" The mean valid temperature is {sumTemp / count:F1} degrees.");// displays the valid sumTemp mean
                }
                else
                    Console.WriteLine("Valid temperature range is -20 to 130. Please reenter temperature.");// if the input is not valid the user is prompted to reenter temperature that is valid
        }
    }
}
