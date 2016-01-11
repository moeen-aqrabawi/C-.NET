/* StatePicker.cs		Author:	Doyle	
 * Allows the user to enter a state
 * abbreviation. A switch statement 
 * is used to display the full name
 * of the state. 
 * *********************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePicker
{
    class StatePicker
    {
        static void Main(string[] args)
        {
            string stateAbbrev;

            Console.WriteLine("Enter the state "
                                + "abbreviation. ");
            Console.WriteLine("Its full name will"
                                + " be displayed");
            Console.WriteLine();
            stateAbbrev = Console.ReadLine();

            switch (stateAbbrev)
            {
                case "AL":
                case "aL":
                case "Al":
                case "al": Console.WriteLine("Alabama");
                    break;
                case "FL": Console.WriteLine("Florida");
                    break;
                case "GA": Console.WriteLine("Georgia");
                    break;
                case "IL": Console.WriteLine("Illinois");
                    break;
                case "KY": Console.WriteLine("Kentucky");
                    break;
                case "MI": Console.WriteLine("Michigan");
                    break;
                case "OK": Console.WriteLine("Oklahoma");
                    break;
                case "TX": Console.WriteLine("Texas");
                    break;
                default: Console.WriteLine("No match");
                    break;
            }
            Console.ReadKey();
        }
    }
}
