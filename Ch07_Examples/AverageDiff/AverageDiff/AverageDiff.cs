/* AverageDiff.cs       Author:Doyle
 * Ten scores are entered. Average is calculated.
 * A table is printed showing how far each 
 * value is from the mean. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageDiff
{
    class AverageDiff
    {
        static void Main(string[] args)
        {
            int total = 0;
            double avg;
            double distance;
            string inValue;
            int[ ] score = new int[10];
 
            // Values are entered
            for (int i = 0; i < score.Length; i++)
            {
                Console.Write("Enter Score{0}: ", i + 1);
                inValue = Console.ReadLine();
                if (int.TryParse(inValue, out score[i]) == false)
                   Console.WriteLine("Invalid data entered - 0 stored in array");
            }

            // Values are summed
            for (int i = 0; i < score.Length; i++)
            {
                total += score[i];
            }
            avg = (double) total / score.Length;

            Console.WriteLine();
            Console.WriteLine("Average: {0}", avg.ToString("F0"));

            // Output produced containing array
            // element and how far the value is
            // from the mean (absolute value).
            Console.WriteLine();
            Console.WriteLine("Score\tDist. from Avg.");
            for (int i = 0; i < score.Length; i++)
            {
                distance = Math.Abs((avg - score[i]));
                Console.WriteLine("{0}\t\t{1}", score[i], distance.ToString("F0"));
            }
            Console.ReadKey();
        }
    }
}