﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContinueExample
{
    class ContinueExample
    {
        static void Main(string[] args)
        {
            int total = 0;
            for (int nValue = 0; nValue < 10; nValue++)
            {
                if (nValue % 2 == 0)
                {
                    continue;
                }
                total += nValue;
                Console.Write(nValue + "\t");
            }
            Console.WriteLine("\nTotal is equal to {0}.", total);
            Console.ReadKey();
        }
    }
}
