/* BonusCalculator.cs	Author:	Doyle	
 * Allows the user to input their
 * gross sales for the year. This value
 * is checked to determine whether
 * a bonus is in order.  
 **************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusCalculatorApp
{
    class BonusCalculatorApp
    {
        static void Main(string[] args)
        {
            string inValue;
            decimal salesForYear;
            decimal bonusAmount = 0M;

            Console.WriteLine("Do you get a bonus this year?");
            Console.WriteLine();
            Console.WriteLine("To determine if you are due one,");
            Console.Write("enter your gross sales figure: ");
            inValue = Console.ReadLine();
            salesForYear = Convert.ToDecimal(inValue);

            if (salesForYear > 500000.00M)
            {
                Console.WriteLine();
                Console.WriteLine("YES...you get a bonus!");
                bonusAmount = 1000.00M;
            }
            Console.WriteLine("Bonus for the year: {0:C}",
                                bonusAmount);
            Console.ReadLine();
        }
    }
}