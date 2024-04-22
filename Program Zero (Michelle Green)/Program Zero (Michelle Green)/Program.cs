//5436514
//Program 0
//09/08/2023
//CIS 200-75-4238
// The program class where my console application is created
using Program_Zero__Michelle_Green_;

internal class Program
{
    private static void Main(string[] args)
    {
        Laptop acer= new Laptop("acer", "aspire 3", 165 , "core i3 1115G4" );
        CPU amd= new CPU("amd", "ryzen 9 7950X",5000, "socket am5", 125 );
        CPU intel= new CPU("intel", "core i7 12700K", 5000, "socket LGA 1700", 125);
        CPU amd2= new CPU("amd", "ryzen 5 5600X", 3700, "socket am4", 65);

        List<Computer> computers= new List<Computer>();//computer list method
       
        computers.Add(acer);

        List<CPU> cpus = new List<CPU>();//cpu list method 
        cpus.Add(amd);
        cpus.Add(intel);
        cpus.Add(amd2);
    }
}