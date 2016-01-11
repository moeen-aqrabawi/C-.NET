using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapData
{
    class SwapDataApp
    {
        static void Main(string[] args)
        {
            TestSwap();
            Console.ReadKey();
        }

        public static void SwapData<T>(ref T first, ref T second)
        {
            T temp;
            temp = first;
            first = second;
            second = temp;
        }

        public static void TestSwap()
        {
            string firstValue = "Programming";
            string secondValue = "C#";

            int aValue = 75;
            int bValue = 90;

            SwapData<string>(ref firstValue, ref secondValue);
            System.Console.WriteLine(firstValue + " " + secondValue);

            SwapData<int>(ref aValue, ref bValue);
            System.Console.WriteLine(aValue + " " + bValue);
        }
    }
}
