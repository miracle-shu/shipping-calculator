using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace shipping_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Shipping Cost Calculator");
        Console.WriteLine("------------------------");
        Console.WriteLine("Enter the shipping distance:");
        double distance = double.Parse(Console.ReadLine());
            double totalCost;

            if (distance <= 100)
            {
                totalCost = (distance * 1.20) + 10;
                Console.WriteLine($"The total shipping cost for {distance} miles is: £{totalCost:f2}");
            }
            else if (distance > 100 && distance <= 500)
            {
                totalCost = 10 + (100 * 1.20) + (distance - 100) * (1.05);
                Console.WriteLine($"The total shipping cost for {distance} miles is: £{totalCost:f2}");
            }
            else if (distance > 500)
            {
                totalCost = 10 + (100 * 1.20) + (400 * 1.05) + (distance - 500) * (0.80);
                Console.WriteLine($"The total shipping cost for {distance} miles is: £{totalCost:f2}");
            } 
        }
    }
}
