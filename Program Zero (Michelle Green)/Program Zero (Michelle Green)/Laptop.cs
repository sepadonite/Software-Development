//5436514
//Program 0
//09/08/2023
//CIS 200-75-4238
// The Laptop class where the laptop and its parameters are identified
//My issue resided in this class and I have no idea where the issue is
using System;
using System.Net.Sockets;
using System.Reflection;

namespace Program_Zero__Michelle_Green_
{
	public class Laptop : Computer //precondition: computer class must exist
		//postcondition: n/a
	{
		private string model;//model variable

		public Laptop(string manufacturer, string model, int powerDraw, string cpu)
        //precondition: variables must be declared
        //postcondition: fields above are initialized an instance is created
        {
            model = LaptopModel;

		}

		public string LaptopModel//precondition: must be included in constructor overload
			//postcondition: value return is set in place
        {
			get//precondition: must be in the constructor and overload
			{
				return model;
			}
            set//postcondition: string cannot be empty if error appears
            {

				if (!string.IsNullOrWhiteSpace(value))
				{
					model = value;

				}
				else
				{
					throw new ArgumentOutOfRangeException("Please enter model.");//error message
                }
			}
		}
        public override string ToString()//precondition: a string method must exist 
			//postcondition:n/a
        {
            return $"{Manufacturer}" +
                $"Clock Speed: {LaptopModel}" +
                $"Socket: {PowerDraw}" +
                $"Power Draw: {CPU}";
        }

    }
}

