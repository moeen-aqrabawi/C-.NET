/* InputValuesLoop.cs       Author: Doyle
 * Demonstrates loop for inputting values. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputValuesLoop
{
    class InputValuesLoop
    {
        static void Main(string[] args)
        {
            string inValue = "";

            Console.Write("This program will let you enter");
            Console.Write(" value after value. To Stop, enter");
            Console.WriteLine(" -99");
            while (inValue != "-99")
            {
                Console.WriteLine("Enter value (-99 to exit)");
                inValue = Console.ReadLine();
            }
            Console.ReadKey();
        }
    }
}
