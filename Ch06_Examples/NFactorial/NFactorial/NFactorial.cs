/* NFactorial.cs      Author: Doyle
 * Computes n factorial -
 * the produce of the first n
 * positive integers. 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFactorial
{
    class NFactorial
    {
        static void Main(string[] args)
        {
            int result;

            string moreData;
            int n;

            DisplayInformation();

            do
            {
                n = InputN();
                CalculateNFactorialIteratively(n, out result);
                DisplayNFactorial(n, result);
                moreData = PromptForMoreCalculations();
            }
            while (moreData == "y" || moreData == "Y");
            Console.ReadKey();
        }

        public static void DisplayInformation()
        {
            Console.WriteLine("n! represents the product"
                               + " of the first n integers");
        }

        public static void CalculateNFactorialIteratively(int n, out int result)
        {
            result = 1;
            for (int i = n; i > 0; i--)
            {
                result *= i;
            }

        }

        public static int InputN()
        {
            string inValue;
            int n;

            Console.Write("\nEnter the number to "
                           + "use to compute n! ");
            inValue = Console.ReadLine();
            if (int.TryParse(inValue, out n) == false)
                Console.WriteLine("Invalid input - 0 recorded for n");
            return n;
        }

        public static void DisplayNFactorial(int n, int result)
        {
            Console.WriteLine("{0}! is {1}.", n, result);
        }

        public static string PromptForMoreCalculations()
        {
            string moreData;
            Console.WriteLine("\nDo you want to calculate"
                               + " another factorial?");
            Console.WriteLine("Enter y for another "
                               + "calculation. \nAny other "
                               + "character to stop.");
            moreData = Console.ReadLine();
            return moreData;
        }
    }

}
