//5436514
//Program 0
//09/08/2023
//CIS 200-75-4238
// The CPU class where and parameters are identified
using System;

namespace Program_Zero__Michelle_Green_
{
	public  class CPU
	{ 
		private string manufacturer;//the name of the manufacturer variable
		private string model;//the name of the model variable
		public int clockSpeed;// the clock speed in MHz variable
		public string socket;// the socket name variable
		public int powerDraw;//the power draw in watts variable

		public CPU(string manufacturer, string model, int clockSpeed, string socket, int powerDraw)
			//precondition: variables must be declared
			//postcondition: fields above are initialized an instance is created
		{
			Model = model;
			ClockSpeed = clockSpeed;
			Socket = socket;
			PowerDraw = powerDraw;
				//defines multiple constructors
		}

	
		public string Model//precondition: must be included in constructor overload
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
		public int ClockSpeed //in MHz//precondition: must be included in constructor overload
                              //postcondition: value return is set in place
        {
            get//precondition: must be in the constructor and overload
            {
				return clockSpeed;
			}
            set//postcondition: value must be greater that zero if not deafault is pluged in
            {
				if (value > 0)
				{
					ClockSpeed = value;
				}
				else
				{
					ClockSpeed = 3500;//deafault
				}
			}
		}
		public string Socket//precondition: must be included in constructor overload
                            //postcondition: value return is set in place
        {
            get//precondition: must be in the constructor and overload
            {
				return socket;
			}
            set//postcondition: string cannot be empty if error appears
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    socket = value;

                }
                else
                {
                    throw new ArgumentOutOfRangeException("Please enter socket.");//error message
                }
            }
		}
		public int PowerDraw//precondition: must be included in constructor overload
                            //postcondition: value return is set in place
        {
            get//precondition: must be in the constructor and overload
            {
				return powerDraw;
			}
			set//postcondition: value must be greater that zero if not deafault is pluged in
			{
				if (value > 0)
				{
					powerDraw = value;
				}
				else
				{
					powerDraw = 2000;//deafault
				}

			}
		}
        public int CalcTDP()// calculates the power draw 
        {
            return PowerDraw;
        }


		public override string ToString() //precondition: a string method must exist
			//postcondition: n/a
		{
			return $"{Model}" +
				$"Clock Speed: {ClockSpeed}" +
				$"Socket: {Socket}" +
				$"Power Draw: {PowerDraw}";
		}
    }

}

