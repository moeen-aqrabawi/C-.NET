
using System;


namespace ErrorExample
{
    class ErrorExample
    {
        static void Main(string[] args)
        {
            // Exception thrown for division by zero
            int totalScores = 10,
               countOfScores = 0;
            double average;
            average = totalScores / countOfScores;


            //// Syntax error produced
            //int[] numbers = new int[10];
            //foreach (int val in numbers) ;
            //Console.WriteLine(val);
        }
    }
}