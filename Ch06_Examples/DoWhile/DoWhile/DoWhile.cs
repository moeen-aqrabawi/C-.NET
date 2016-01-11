using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile
{
    class DoWhile
    {
        static void Main(string[] args)
        {
            int counter = 10;
            do                  // No semicolon on this line
            {
                Console.WriteLine(counter + "\t" + Math.Pow(counter, 2));
                counter--;
            }
            while (counter > 0);

            Console.ReadKey();
        }
    }
}