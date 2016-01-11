/* ValidInput.cs    Author: Doyle
 *  Demonstrates testing input to 
 *  ensure that integers are entered.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidInput
{
    class Program
    {
        static void Main(string[] args)
        {
            int integerValue;
            string inStringValue;

            Console.Write("Enter an integer value. ");
            inStringValue = Console.ReadLine();
            while (int.TryParse(inStringValue, out integerValue) == false)
            {
                Console.WriteLine("Invalid input");
                Console.Write("Please re-enter an integer value. ");
                inStringValue = Console.ReadLine();
            }

            Console.WriteLine("Valid value entered: " + integerValue);
            Console.ReadKey();
        }
    }
}
