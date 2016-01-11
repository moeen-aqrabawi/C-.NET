/* PrimeRead.cs       Author: Doyle
 * Sentinel loop to sum values 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeRead
{
    class PrimeRead
    {
        static void Main(string[] args)
        {
            string inValue = "";
            int sum = 0,
                intValue;

            Console.Write("This program will let you enter");
            Console.Write(" value after value. To Stop, enter");
            Console.WriteLine(" -99");
            Console.WriteLine("Enter value (-99 to exit)");
            inValue = Console.ReadLine();

            while (inValue != "-99")
            {
                if (int.TryParse(inValue, out intValue) == false)
                    Console.WriteLine("Invalid input - 0 stored in intValue");
                sum += intValue;
                Console.WriteLine("Enter value (-99 to exit)");
                inValue = Console.ReadLine();
            }
            Console.WriteLine("Total values entered {0}", sum);
            Console.ReadKey();
        }
    }
}