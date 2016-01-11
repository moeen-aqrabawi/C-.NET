using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    class ForLoop
    {
        static void Main(string[] args)
        {
            for (int counter = 0; counter < 11; counter++)   //Line 1
            {
                Console.WriteLine("{0}\t{1}\t{2}",         //loop body
                      counter,
                      Math.Pow(counter, 2),
                      Math.Pow(counter, 3));
            }

            ////int counter;
            //Console.WriteLine(counter);


            //// Example 6.11 - illustrating how this could be done with a while loop
            //int counter = 0;
            //while (counter < 11)
            //{
            //    Console.WriteLine("{0}\t{1}\t{2}",
            //    counter,
            //    Math.Pow(counter, 2),
            //    Math.Pow(counter, 3));
            //    counter++;
            //}


            Console.ReadKey( );
        }
    }
}