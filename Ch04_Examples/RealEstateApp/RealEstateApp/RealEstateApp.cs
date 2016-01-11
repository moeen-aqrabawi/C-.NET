/* RealEstateApp.cs 	Author:	Doyle	
 * This class constructs an
 * object of the RealEstateInvestment
 * class. It test several properties and
 * methods of the class.
 * A static method is used in
 * the application class to
 * input expenses.   
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp
{
    class RealEstateApp
    {
        static void Main(string[] args)
        {
            const double RENTAL_AMOUNT = 1000.00;

			RealEstateInvestment invest1 = new 
				RealEstateInvestment(2004,150000,
									"65th Street");
            Console.WriteLine("\tFirst Investment");
            invest1.MonthlyExpense = GetExpenses( );
			invest1.IncomeFromRent = RENTAL_AMOUNT;
			Console.WriteLine( );
			Console.WriteLine("Property Location: {0}", 
								invest1.StreetAddress);
			Console.WriteLine("Earnings For Month: {0:C}",
						invest1.DetermineMonthlyEarnings( ));

            RealEstateInvestment invest2 = new
                RealEstateInvestment("72 Westchester Dr.", 229000);
        
            invest2.MonthlyExpense = 900;
            invest2.IncomeFromRent = 1500.00;
            Console.WriteLine("\n\n\tSecond Investment");
            Console.WriteLine(invest2);
            Console.ReadKey();
		}


		public static double GetExpenses( )
		{
			double insurance;
			double taxes;
			double utilities;
			string inValue;

			Console.Write("Yearly Insurance: ");
			inValue = Console.ReadLine();
			insurance = double.Parse(inValue);
			Console.Write("Yearly Tax: ");
			inValue = Console.ReadLine();
			taxes = double.Parse(inValue);
			Console.Write("Monthly Utilities: ");
			inValue = Console.ReadLine();
			utilities = double.Parse(inValue);
			return (insurance / 12 + taxes / 12 
				+ utilities);
        }
    }
}
