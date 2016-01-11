// Multiple catch clauses added to
// catch exception
using System;

namespace MultipleCatches
{
    class MultipleCatches
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

                averageTestScore = totalScores / countOfScores;
                //averageTestScore = (double)totalScores / countOfScores;

                Console.WriteLine("Average is {0}", averageTestScore);
            }
            catch (System.FormatException e)
            {
                Console.Error.WriteLine("Problem with one of " +
                    "the operands - Can not compute average!");
                Console.Error.WriteLine("Exception type: {0}",
                                                  e.Message);
            }

            catch (System.DivideByZeroException e)
            {
                Console.Error.WriteLine("No scores were " +
                    "entered - Can not compute average!");
                Console.Error.WriteLine("Exception type: {0}",
                                                  e.Message);
            }
            catch (System.ArithmeticException e)
            {
                Console.Error.WriteLine("Error in your " +
                    "arithmetic or casting.");
                Console.Error.WriteLine("Exception type: {0}",
                                                  e.Message);
            }
            catch (System.Exception e)
            {
                Console.Error.WriteLine("Any other problem" +
                    "Can not compute average!");
                Console.Error.WriteLine("Exception type: {0}",
                                                  e.Message);
            }
            finally
            {
                Console.WriteLine("...\n...\n...\n" +
                    "Terminated Normally!!!");
            }
            Console.ReadKey();
        }
    }
}
