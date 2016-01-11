/* TicketApp.cs		Author:	Doyle	
 * Instantiates a Ticket object
 * from the inputted values of
 * speed and speed limit. Uses 
 * the year in school classification
 * to set the fine amount. 
 * *********************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketApp
{
    class TicketApp
    {
        static void Main(string[] args)
        {
            string studentNumber;
			char classif;
            int speedLimit,
				speed;

            studentNumber = InputStudentNumber();
			speedLimit = InputSpeed("Speed Limit");
			speed = InputSpeed("Ticketed Speed");
			classif = InputYearInSchool( );
			
			Ticket studentTicket = new Ticket(studentNumber, classif, 
                                            speedLimit, speed);
            Console.Clear();
            Console.WriteLine(studentTicket);
            Console.ReadKey( );
		}

        public static string InputStudentNumber()
        {
            string sNumber;
            Console.Write("Enter Student Number: ");
            sNumber = Console.ReadLine();
            return sNumber;
        }

		public static int InputSpeed(string whichSpeed)
		{
			string inValue;
            int speed;

			Console.Write("Enter the {0}: ", whichSpeed);
			inValue = Console.ReadLine();
            if (int.TryParse(inValue, out speed) == false)
                Console.WriteLine("Invalid entry entered for {0} - " +
                    "0 was recorded", whichSpeed);
			return speed;
		}

		public static char InputYearInSchool ( )
		{
			string inValue;
			char yrInSchool;
			Console.WriteLine("Enter your classification:" );
			Console.WriteLine("\tFreshmen (enter 1)");
			Console.WriteLine("\tSophomore (enter 2)");
			Console.WriteLine("\tJunior (enter 3)");
			Console.Write("\tSenior (enter 4)");
			Console.WriteLine();
            inValue = Console.ReadLine();
			yrInSchool = Convert.ToChar(inValue);
			return yrInSchool;
        }
    }
}
