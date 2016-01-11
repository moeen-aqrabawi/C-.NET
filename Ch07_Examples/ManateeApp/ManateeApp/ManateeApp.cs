/* ManateeApp.cs       Author: Doyle
 * This is the client program that uses the
 * ManateeSighting class. Users are prompted
 * for location, date and sightings. The
 * ManateeSighting class is tested using 
 * this class by calling many of the methods
 * and properties.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManateeApp
{
    class ManateeApp
    {
        static void Main(string[] args)
        {
            string location;
            int sightingCnt;
            string[] dArray = new String[20];
            int[] manateeCnt = new int[20];
            char enterMoreData = 'Y';
            ManateeSighting m;

            do
            {
                sightingCnt = GetData(out location, dArray, manateeCnt);
                            m = new ManateeSighting(location,
                                                    dArray,
                                                    manateeCnt,
                                                    sightingCnt);
                Console.Clear();
                Console.WriteLine(m);

                Console.Write("\n\n\n\nDo you want to enter more data - " +
                              "(Enter y or n)? ");
                if (char.TryParse(Console.ReadLine( ), out enterMoreData) == false)
                    Console.WriteLine("Invalid data entered - " +
                                        "No recorded for your respones");
            } while (enterMoreData == 'y' || enterMoreData == 'y');

            Console.ReadKey();
        }

        public static int GetData(out string location, string[] dArray, int[] manateeCnt)
        {
            int i,
                loopCnt;

            Console.Clear();
            Console.Write("Location: ");
            location = Console.ReadLine();
            Console.Write("How many records for {0}? ", location);
            string inValue = Console.ReadLine();
            if (int.TryParse(inValue, out loopCnt) == false)
                Console.WriteLine("Invalid data entered - " +
                                    "0 recorded for number of records");
            for (i = 0; i < loopCnt; i++)
            {
                Console.Write("\nDate (mm/dd/yyyy): ");
                dArray[i] = Console.ReadLine();
                if (dArray[i] == "")
                {
                    Console.WriteLine("No date entered - " +
                                        "Unknown recorded for sightings");
                    dArray[i] = "Unknown";
                }
                Console.Write("Number of Sightings: ");
                inValue = Console.ReadLine();
                if (int.TryParse(inValue, out manateeCnt[i]) == false)
                    Console.WriteLine("Invalid data entered - " +
                                        "0 recorded for manatee sightings");
            }
            return i;
        }
    }
}
