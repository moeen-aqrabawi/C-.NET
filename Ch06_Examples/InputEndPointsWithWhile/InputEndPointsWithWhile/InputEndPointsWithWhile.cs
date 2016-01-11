using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputEndPointsWithWhile
{
    class InputEndPointsWithWhile
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int startValue,
               endValue;
            string inValue;
            Console.Write("Enter the beginning value: ");
            inValue = Console.ReadLine();
            if (int.TryParse(inValue, out startValue) == false)
                Console.WriteLine("Invalid input - 0 recorded for start value");
            Console.Write("Enter the last value: ");
            inValue = Console.ReadLine();
            if (int.TryParse(inValue, out endValue) == false)
                Console.WriteLine("Invalid input - 0 recorded for end value");
            Console.Write("Sum of values {0} through {1} ",
                            startValue, endValue);
            while (startValue < endValue + 1)
            {
                sum = sum + startValue;
                startValue++;
            }
            Console.WriteLine("is {0}", sum);
            Console.ReadKey();
        }
    }
}
