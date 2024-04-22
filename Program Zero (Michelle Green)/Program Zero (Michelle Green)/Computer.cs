//5436514
//Program 0
//09/08/2023
//CIS 200-75-4238
// The Computer class the top of the heirarchy where the computuer and parameters are identified
using System;
using System.Reflection;

namespace Program_Zero__Michelle_Green_
{
    public abstract class Computer 
    {
        private string manufacturer;//maufacuturer variable
        private string cpu;//cpu variable

        public Computer(string manufacturer, string cpu)//possible issue in failing of code
             //precondition: variables must be declared
            //postcondition: fields above are initialized an instance is created
        {
            manufacturer = Manufacturer;
            cpu = CPU;
        }
        public string Manufacturer//precondition: must be included in constructor overload
                                  //postcondition: value return is set in place
        {
            get//precondition: must be in the constructor and overload
            {
                return manufacturer;
            }
            set//postcondition: string cannot be empty if error appears
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    manufacturer = value;

                }
                else
                {
                    throw new ArgumentOutOfRangeException("Please enter model.");//error message
                }
            }
        }

        
        public string CPU//precondition: must be included in constructor overload
                         //postcondition: value return is set in place
        {
            get//precondition: must be in the constructor and overload
            {
                return cpu;
            }
            set//postcondition: string cannot be empty if error appears
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    cpu = value;

                }
                else
                {
                    throw new ArgumentOutOfRangeException("Please enter cpu.");//error message
                }

            }

        }
        public int CalcTDP() //could not figure out the issue with this
        {
            return powerDraw;
        }

    }
}
