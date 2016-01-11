using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedLoop
{
    class NestedLoop
    {
        static void Main(string[] args)
        {
            int inner;
            for (int outer = 0; outer < 3; outer++)
            {
                for (inner = 10; inner > 5; inner--)
                {
                    Console.WriteLine("Outer: {0}\tInner: {1}", outer, inner);
                }
            }
            Console.ReadKey();
        }
    }
}
