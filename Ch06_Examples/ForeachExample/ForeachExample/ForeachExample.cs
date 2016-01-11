using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachExample
{
    class ForeachExample
    {
        static void Main(string[] args)
        {
            int [ ] numbers = { 2, 4, 6, 8, 10};

            foreach (int val in numbers) 
                Console.WriteLine(val);

            Console.ReadKey();
		}
	}
}
