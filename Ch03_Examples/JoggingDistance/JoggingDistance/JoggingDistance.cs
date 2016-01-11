/* JoggingDistance.cs
 * Author: Doyle
 * This application calculates the jogging distance. 
 * Users are asked to enter the number of 
 * strides ran during the first and last minute 
 * and the total jogging time. A 2.5 stride is used
 * for calculation.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoggingDistance
{
    class JoggingDistance
    {
        static void Main(string[] args)
        {
            int initialStrideCount,
                   finalStrideCount,
                   hrs,
                   mins,
                   totalMinutes;
            double numberOfStepsPerMin,
                   distanceTraveled;

            DisplayInstructions();

            initialStrideCount = GetNumberStrides("first");
            finalStrideCount = GetNumberStrides("last");
            InputJoggingTime(out hrs, out mins);

            totalMinutes = CalculateTime(hrs, mins);
            numberOfStepsPerMin = CalculateAvgSteps(initialStrideCount,
                                                finalStrideCount);
            distanceTraveled = CalculateDistance(numberOfStepsPerMin,
                                                 totalMinutes);

            DisplayResults(numberOfStepsPerMin, hrs, mins,
                            distanceTraveled);
            Console.ReadKey();
        }

        public static void DisplayInstructions()
        {
            Console.WriteLine("How many miles did you jog?");
            Console.WriteLine("Distance (in miles) will be calculated");
            Console.WriteLine("based on stride and number of steps");
            Console.WriteLine("taken per minute.\n");
            Console.WriteLine("You will be asked to enter ");
            Console.WriteLine("your initial and ending strides...");
            Console.WriteLine("OR how many steps you took the ");
            Console.WriteLine("first minute and how many ");
            Console.WriteLine("steps during the last minute.");
            Console.WriteLine("Average stride is calculated from ");
            Console.WriteLine("those entries.\n");
            Console.WriteLine("Calculations are based on a ");
            Console.WriteLine("2.5 feet stride-each step is 2.5 feet long.");
            Console.WriteLine();
            Console.WriteLine("\nYou will also be asked to enter ");
            Console.WriteLine("the length of time (hours and minutes)");
            Console.WriteLine("you jogged.");
            Console.WriteLine();
            Console.WriteLine("Press any key when you are ready to begin!");
            Console.ReadKey();
            Console.Clear();
        }
        
        public static int GetNumberStrides(string when)
        {
            string inputValue;
            int numberOfSteps;
            Console.Write("Enter number of steps taken " +
                          "during {0} minute: ", when);
            inputValue = Console.ReadLine();
            numberOfSteps = int.Parse(inputValue);
            return numberOfSteps;
        }
        
        public static int CalculateTime(int hrs, int mins)
        {
            return hrs * 60 + mins;
        }
        
        public static double CalculateAvgSteps(int initialStrideCount,
                                            int finalStrideCount)
        {
            return (initialStrideCount + finalStrideCount) / 2.0;
        }
        
        public static void InputJoggingTime(out int hrs, out int mins)
        {
            string inputValue;

            Console.WriteLine("\nHow much time did you spend jogging?");
            Console.Write("Hours: ");
            inputValue = Console.ReadLine();
            hrs = int.Parse(inputValue);
            Console.Write("Minutes: ");
            inputValue = Console.ReadLine();
            mins = int.Parse(inputValue);
        }
        
        public static double CalculateDistance(double numberOfStepsPerMin,
                                                int totalMinutes)
        {
            const double STRIDE = 2.5;
            const int FEET_PER_MILE = 5280;

            return numberOfStepsPerMin * STRIDE * totalMinutes / FEET_PER_MILE;
        }
        
        public static void DisplayResults(double numberOfStepsPerMin, int hrs,
                                            int mins, double distanceTraveled)
        {
            Console.Clear();
            Console.WriteLine("{0,35}", "Jogging Distance Calculator");
            Console.WriteLine();
            Console.WriteLine("{0,-25} {1} Feet Per Step", "Stride:", 2.5);
            Console.WriteLine("{0,-25} {1} Steps", "Strides Per Minute: ",
                              numberOfStepsPerMin);
            Console.WriteLine("{0,-25} {1} Hour(s) and {2} Minute(s)",
                              "Jogging Time:", hrs, mins);
            Console.WriteLine("{0,-25} {1:f2} Miles", "Distance Traveled:",
                              distanceTraveled);
        }
    }
}
