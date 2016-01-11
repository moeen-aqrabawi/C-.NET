/* CarpetExampleWithClassMethods.cs		
 * Author:	 Doyle	 
 * Calculates the total cost of carpet. User
 * inputs room dimensions and carpet price.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpetExampleWithClassMethods
{
    class CarpetExampleWithClassMethods
    {
        static void Main(string[] args)
        {
            double roomWidth;
			double roomLength;
            double pricePerSquareYard;
            double noOfSquareYards;

			DisplayInstructions( );
			
			// Call GetDimension( ) to get the length
			roomLength = GetDimension("Length");
				
			// Call GetDimension( ) again to get the width
			roomWidth = GetDimension("Width");
            pricePerSquareYard = GetPrice();
            noOfSquareYards = 
			DetermineSquareYards(roomWidth, roomLength);
            DisplayResults(noOfSquareYards, pricePerSquareYard);
            Console.ReadKey();
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

			Console.Write("Enter the {0} in feet: ",
							side);
			inputValue = Console.ReadLine();
			feet =	int.Parse(inputValue);
			Console.Write("Enter the {0} in inches: ",
							side);
			inputValue = Console.ReadLine();
			inches = int.Parse(inputValue);

			// Note: cast required to avoid int division
			return (feet + (double) inches / 12); 
		}

		public static double GetPrice()
		{
			string inputValue;	// local variables
			double price;

			Console.Write("Enter the price per Square" 
							+ "Yard: ");
			inputValue = Console.ReadLine();
			price = double.Parse(inputValue);
			return price;
		}

		public static double DetermineSquareYards(double width,  
											double length)
		{
			const int SQ_FT_PER_SQ_YARD = 9;

			double noOfSquareYards;
			noOfSquareYards = length * width 
								/ SQ_FT_PER_SQ_YARD;
			return noOfSquareYards;
		}

	    public static double DeterminePrice(double squareYards,  
										double pricePerSquareYard)
		{
			return (pricePerSquareYard * squareYards);
		}

		public static void DisplayResults(double squareYards, 
									double pricePerSquareYard)
		{
			Console.WriteLine( );
			Console.Write("Square Yards needed: ");
			Console.WriteLine("{0:N2}", squareYards);
			Console.Write("Total Cost at {0:C} ", 
							pricePerSquareYard); 		
			Console.WriteLine(" per Square Yard: {0:C}",
                    DeterminePrice(squareYards, pricePerSquareYard));
        }
    }
}
