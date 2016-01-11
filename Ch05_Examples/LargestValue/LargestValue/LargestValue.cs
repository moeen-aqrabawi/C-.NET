using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestValue
{
    class LargestValue
    {
        static void Main(string[] args)
        {
            int value1,
				value2,
				largestOne;			

			InputValues(out value1, out value2);
			largestOne = DetermineLargest(value1, value2);
			PrintResults(largestOne);
            Console.ReadKey();
		}

		public static void InputValues(out int v1, out int v2)
		{
			string inValue;

			Console.Write("Enter the first value: ");
            inValue = Console.ReadLine();
            if (int.TryParse(inValue, out v1) == false)
                Console.WriteLine("Did not input a valid integer - 0 stored in v1");
			Console.Write("Enter the second value: ");
			inValue = Console.ReadLine();
            if (int.TryParse(inValue, out v2) == false)
                Console.WriteLine("Did not input a valid integer - 0 stored in v2");
        }
		
		public static int DetermineLargest(int value1, int value2)
		{
			int largestOne;	//local variable declared to 
							//facilitate single exit from 							
							//method

			if(value1 > value2)
			{
				largestOne = value1;
			}
			else
			{
				largestOne = value2;
			}
			return largestOne;
		}

		public static void PrintResults(int largestOne)
		{
			Console.WriteLine( );
			Console.WriteLine("The largest value entered was "
				+ largestOne);
			Console.WriteLine("Its square root is {0:f2}",
				Math.Sqrt(largestOne));
			Console.ReadLine( );
		}
    }
}
