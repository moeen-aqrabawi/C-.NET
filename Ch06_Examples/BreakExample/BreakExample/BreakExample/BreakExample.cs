using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakExample
{
    class BreakExample
    {
        static void Main(string[] args)
        {
            int total = 0;
            for (int nValue = 0; nValue < 10; nValue++)
            {
                if (nValue == 5)
                {
                    break;
                }
                total += nValue;
                Console.Write(nValue + "\t");
            }
            Console.WriteLine("\nTotal is equal to {0}.", total);
            Console.ReadKey();
        }
    }
}