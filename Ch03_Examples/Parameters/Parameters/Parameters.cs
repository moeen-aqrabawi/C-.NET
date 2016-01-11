/* Parameters.cs
* Author Doyle
* This class demonstrates the
* differences between the
* default, ref, and out
* parameter types */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    class Parameters
    {
        public static void Main(string[] args)
        {
            int testValue = 1;

            Console.WriteLine("Original "
                + "Value: {0}", testValue);
            TestDefault(testValue);
            Console.WriteLine("Upon return from TestDefault "
                + "Value: {0}", testValue);
            Console.WriteLine();


            Console.WriteLine("Original "
                + "Value: {0}", testValue);
            TestRef(ref testValue);
            Console.WriteLine("Upon return from TestRef"
                + "Value: {0}", testValue);
            Console.WriteLine();


            // variable does not have to be initialized
            int testValue2;
            //			Console.WriteLine("Original "
            //				+ "Value: {0}", testValue2);
            TestOut(out testValue2);
            Console.WriteLine("Upon return from TestOut"
                + "Value: {0}", testValue2);
            Console.Read();
        }

        public static void TestDefault(int aValue)
        {
            aValue = 111;
            Console.WriteLine("In TestDefault -"
                + "Value: "
                + "{0}", aValue);
        }

        public static void TestOut(out int aValue)
        {
            aValue = 222;
            Console.WriteLine("In TestOut -"
                + "Value: "
                + " {0} ", aValue);
        }

        public static void TestRef(ref int aValue)
        {
            aValue = 333;
            Console.WriteLine("Inside TestRef -"
                + "Value: "
                + "{0}", aValue);
        }
    }
}
