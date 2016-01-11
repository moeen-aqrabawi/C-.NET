/* CarpetCalculatorApp.cs
* Author: Doyle
* This class instantiates an object
* of the CarpetCalculator class. It
* demonstrates how to access and use
* the members of the class.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpetCalculatorApp
{
    public class CarpetCalculatorApp
    {
        static void Main(string[] args)
        {
            CarpetCalculator berber = new CarpetCalculator (17.95);

			double roomWidth;
			double roomLength;

			DisplayInstructions( );
			
			// Call getDimension( ) to get the length
			roomLength = GetDimension("Length");
				
			// Call getDimension( ) again to get the width
			roomWidth = GetDimension("Width");
			berber.SetNoOfSqYards(roomLength, roomWidth);
            berber.PricePerSqYard = 25.99;
            Console.Clear();
            Console.Write(berber);
            Console.ReadLine();
		}
	
		public static void DisplayInstructions( )
		{
			Console.WriteLine("This program will " 
				+ "determine how much "
				+ "carpet to purchase.");
			Console.WriteLine();
			Console.WriteLine("You will be asked to enter "
				+ "the size of the room ");
			Console.WriteLine("and the price of the carpet, "
				+ "in price per square yds.");
			Console.WriteLine();
		}

		public static double GetDimension(string side )
		{
			string inputValue;	// local variables
			int feet,			// needed only by this 
				inches;			// method

			Console.Write("Enter the {0} in feet: ", side);
			inputValue = Console.ReadLine();
			feet =	int.Parse(inputValue);
			Console.Write("Enter the {0} in inches: ", side);
			inputValue = Console.ReadLine();
			inches = int.Parse(inputValue);

			// Note: cast required to avoid int division
			return (feet + (double) inches / 12); 
		}

        // //With the ToString( ) method, there is no longer a need for 
        // // the DisplayResults( ) method
        // // It is left in the solution to illustrate sending an
        // // entire class object to a method
        //static void DisplayResults(CarpetCalculator carpet )
        //{
        //    Console.WriteLine( );
        //    Console.Write("Square Yards needed: ");
        //    Console.WriteLine("{0:N2}", carpet.GetNoOfSquareYards());
        //    Console.Write("Total Cost at {0:C} ", 
        //        carpet.Price); 		
        //    Console.WriteLine(" per Square Yard: {0:C}",
        //        carpet.DetermineTotalCost( ));
        //}
        }
    }
