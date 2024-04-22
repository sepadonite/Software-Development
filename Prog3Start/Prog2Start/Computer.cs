using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Prog3Start
{

    [XmlInclude(typeof(Laptop))]
    [XmlInclude(typeof(Desktop))]
    [XmlInclude(typeof(AllInOne))]
    [XmlInclude(typeof(Tower))]

    [Serializable]
    abstract class Computer
    {
        private string manufacturer;
        private CPU cpu;

        public Computer(string manufacturer, CPU cpu)
        {
            Manufacturer = manufacturer;
            CPU = cpu;
        }
        public Computer()
        {

        }

        public string Manufacturer
        {
            get
            {
                return manufacturer;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    manufacturer = value.Trim();
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public CPU CPU
        {
            get
            {
                return cpu;
            }
            set
            {
                //no need to validate, as only valid objects can be passed in
                cpu = value;
            }
        }


        public abstract double CalcTDP();

        public override string ToString()
        {
            return $"Manufacturer: {Manufacturer} \nCPU Details: {CPU}";
        }
    }
}
