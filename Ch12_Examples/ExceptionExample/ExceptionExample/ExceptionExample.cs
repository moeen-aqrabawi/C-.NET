// ExceptionApp.cs   
// Uses a generic catch block to catch any
// type of exception that is thrown.
using System;

namespace ExceptionExample
{
    class ExceptionExample
    {
        static void Main(string[] args)
        {
            int[] examScore;
            int totalScores = 0;
            int countOfScores = 0;
            string inValue;
            double averageTestScore;

            try
            {
                Console.Write("How many scores will you enter? ");
                inValue = Console.ReadLine();
                countOfScores = int.Parse(inValue);
                examScore = new int[countOfScores];

                for (int i = 0; i < countOfScores; i++)
                {
                    Console.Write("Enter score {0}: ", i + 1);
                    inValue = Console.ReadLine();
                    examScore[i] = int.Parse(inValue);
                    totalScores += examScore[i];

                }

                ////Commented out lines used with Example 11-3
                //averageTestScore = totalScores / examScore[10];  // threw exception

                averageTestScore = totalScores / countOfScores;
                Console.WriteLine("Average is {0}", averageTestScore);
            }

            catch
            {
                Console.WriteLine("Problem with scores - " +
                    "Cannot compute average");
            }

            ////Example 11-4 replaced the above catch clause with the following
            //  catch (System.Exception e)  
            //  {
            //     Console.Error.WriteLine("Problem with scores - " +
            //          "Cannot compute average");
            //      Console.Error.WriteLine(e.Message);
            //  }
            Console.ReadKey();


            //foreach (int val in numbers) ;







        }
    }
}
