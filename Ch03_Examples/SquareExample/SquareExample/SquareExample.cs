/* *********************************************
 * SquareExample.cs		Author:	Doyle	
 * Computes the square of a variable initialized
 * at compile time. 
 * 
 **********************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareExample
{
    class SquareExample
    {
        static void Main(string[] args)
        {
            int aValue = 768;
            int result;

            result = aValue * aValue;
            Console.WriteLine("{0} squared is {1}", aValue, result);
            Console.Read();
        }
    }
}
