/* AgeIncrementer.cs	Author:	Doyle	
 * Displays age one year from now.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeIncrementer
{
    class AgeIncrementer
    {
        static void Main(string[] args)
        {
            int age;
            string aValue;

            Console.Write("Enter your age: ");
            aValue = Console.ReadLine();
            age = int.Parse(aValue);
            Console.WriteLine("Your age next year will be {0}", ++age);
            Console.Read();
        }
    }
}
