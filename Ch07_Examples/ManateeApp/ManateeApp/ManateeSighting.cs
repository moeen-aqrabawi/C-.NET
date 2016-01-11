/* ManateeSighting.cs           Author: Doyle
 * This class defines Manatee characteristics 
 * to include location, count and
 * date of sightings. Methods to determine
 * the month with most sightings and average
 * number of sightings per location included.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManateeApp
{
    class ManateeSighting
    {
        private string location;
        private string[] sightDate;
        private int[] manateeCount;

        // Constructors
        public ManateeSighting()
        {

        }

        public ManateeSighting(string loc)
        {
            location = loc;
        }

        public ManateeSighting(string loc, string[] date,
                                int[] cnt)
        {
            sightDate = new string[date.Length];
            manateeCount = new int[cnt.Length];
            Array.Copy(date, 0, sightDate, 0, date.Length);
            Array.Copy(cnt, 0, manateeCount, 0, manateeCount.LongLength);
            location = loc;
        }

        public ManateeSighting(string loc, string[] date,
                                int[] cnt, int numOfFlights)
        {
            sightDate = new string[numOfFlights];
            manateeCount = new int[numOfFlights];
            Array.Copy(date, 0, sightDate, 0, numOfFlights);
            Array.Copy(cnt, 0, manateeCount, 0, numOfFlights);
            location = loc;
        }

        //Properties
        public string Location
        {
            get
            {
                return location;
            }
            set
            {
                location = value;
            }
        }

        public string[] SightDate
        {
            get
            {
                return sightDate;
            }
            set
            {
                sightDate = value;
            }
        }

        public int [ ] ManateeCount
        {
            get
            {
                return manateeCount;
            }
            set
            {
                manateeCount = value;
            }
        }

        // Determines what the average number of sightings is
        // per location
        public double CalculateAvg()
        {
            double avg;

            int cntOfValidEntries;
            int total = 0;
            foreach (int c in manateeCount)
                    total += c;
            cntOfValidEntries = TestForZeros();
            avg = (double)total / cntOfValidEntries;
            return avg;
        }

        // To avoid skewing average return number
        // of cells with nonzero values
        public int TestForZeros()
        {
            int numberOfTrueSightings = 0;
            foreach (int cnt in manateeCount)
                    if (cnt != 0)
                        numberOfTrueSightings++;
            return numberOfTrueSightings;
        }


        // Returns an index where the largest
        // number of sightings is stored
        public int GetIndexOfMostSightings()
        {
            int maxCntIndex = 0;

            for (int i = 1; i < manateeCount.Length; i++)
                if (manateeCount[i] > manateeCount[maxCntIndex])
                    maxCntIndex = i;
            return maxCntIndex;
        }

        // Returns a count of the most sighted
        public int GetMostSightings()
        {
            return manateeCount[GetIndexOfMostSightings( )];
        }

        // Returns the date when the most sightings occurred
        public string GetDateWithMostSightings()
        {
            return sightDate[GetIndexOfMostSightings( )];
        }

        // Returns the name of the month when the highest sightings occurred
        public string GetMonthWithMostSightings()
        {
            return ReturnMonth(sightDate[GetIndexOfMostSightings()]);
        }

        // Computes the average for a given month
        public double ComputeAverageForMonth(string mon)
        {
            int total = 0;
            int days = 0;
            double monAverage;
            for (int i = 0; i < sightDate.Length; i++)
            {
                if (sightDate[i].StartsWith(mon))
                {
                    total += manateeCount[i];
                    days++;
                }
            }
            if (days > 0)

                monAverage = (double)total / days;
            else
                monAverage = 0;
            return monAverage;
        }

        // Given a date in the format of mm/dd/yyyy
        // the name of the month is returned
        public string ReturnMonth(string someDate)
        {
            string[] monthName = {"January", "February", "March",
                                  "April", "May", "June", "July",
                                  "August", "September", "October",
                                  "November", "December"};

            string[] dateParts = someDate.Split('/');
            dateParts[0] = dateParts[0].TrimStart('0');

            return monthName[Convert.ToInt32(dateParts[0]) - 1];
        }

        public override string ToString()
        {
            return "\tLocation: " + location +
                    "\n\nAverage Number of Sightings:\t" + CalculateAvg().ToString("F1") +
                    "\n\nMonth name for the" +
                    "\nDate of Most Sightings:\t\t" + GetMonthWithMostSightings() +
                    "\n\nDate of Most Sightings:\t\t" + GetDateWithMostSightings() +
                    "\nCount for " + GetDateWithMostSightings() +
                    ":\t\t" + GetMostSightings();

        }
    }
}
