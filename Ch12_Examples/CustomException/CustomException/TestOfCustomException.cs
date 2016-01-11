/* TestOfCustomException.cs 
 * When a floating point value of zero
 * is used as a divisor, the custom
 * designed FloatingPtDvisionException
 * is thrown.
 */
using System;

namespace CustomException
{
    class TestOfCustomException
    {
        static void Main(string[] args)
        {
            double value1 = 0,
                value2 = 0,
                answer;
            try
            {
                // Could include code to enter values
                answer = GetResults(value1, value2);
            }
            catch (FloatingPtDivisionException excepObj)
            {
                Console.Error.WriteLine(excepObj.Message);
            }
            catch
            {
                Console.Error.WriteLine("Something else happened!");
            }
            Console.ReadKey();
        }

        static double GetResults(double value1, double value2)
        {
            if (value2 < 0.0000001) // Be careful with comparing double for equality
            {
                FloatingPtDivisionException excepObj = new
                    FloatingPtDivisionException
                    ("Exception type: " +
                    "Floating-point division by zero");
                throw excepObj;
            }
            return value1 / value2;
        }

    }
}