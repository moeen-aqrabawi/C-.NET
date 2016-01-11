/* TempAgency.cs
 * This application is used by a temporary work agency to
 * set projections for sales for new hires. The program enables the 
 * user to input salesmen's names and expected sales goals.
 * The sales figure is placed in a two-dimensional array 
 * and expected sales figures for four months are added.
 * These projections are based on increasing sales at 
 * least 5% each month over the four month period. 
 * For testing purposes, four salesmen data is entered.
 */

using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace TempAgency
{
    class TempAgency
    {
        static void Main(string[ ] args)
        {
            double[ , ] sales = new double[4, 5];
            string[ ] salesman = new string[4];

            DisplayInstructions( );
            GetSalesData(salesman, sales);
            ProduceSalesProjectionTable(sales);
            DisplaySalesProjections(salesman, sales);

            Console.ReadKey( );
        }

        public static void DisplayInstructions( )
        {
            Console.WriteLine("You will be asked to enter data for " +
                  "four salesmen. \nFor their name, enter their first " +
                  "name followed \nby a space and then their last name." +
                  "\n\nNext you will enter the expected sales for the 1st month. " +
                  "\n\n\nFor testing purposes enter data for four (4) salesmen.\n\n");
            Console.WriteLine( );
        }

        public static void GetSalesData(string[ ] salesman, double[ , ] sales)
        {
            for (int row = 0; row < salesman.Length; row++)
            {
                string fullname;
                string[ ] name = new string[3];

                Console.Write("Name of the New Salesman: ");
                salesman[row] = Console.ReadLine( );
                fullname = salesman[row];
                name = fullname.Split(' ');
                Console.Write("Please enter {0}'s Initial Sales Goal: ", name[0]);
                sales[row, 0] = double.Parse(Console.ReadLine());
                Console.Clear( );
            }
        }
  
        public static void ProduceSalesProjectionTable(double[ , ] sales)
        {
            double salesIncrease;

            DisplayHeading(sales);
            for (int row = 0; row < sales.GetLength(0); row++)
            {
                salesIncrease = 0.05;
                for (int col = 1; col < sales.GetLength(1); col++)
                {
                    sales[row, col] = sales[row, col - 1] * salesIncrease + sales[row, col - 1];
                    salesIncrease += 0.05;
                }
            }
        }

        public static void DisplayHeading(double[ , ] sales)
        {
            double inc = 0.05;

            Console.Write("{0,-20}    {1,-10}", "Salesman", "Initial ");
            for (int col = 0; col < sales.GetLength(1) - 1; col++)
            {
                Console.Write("{0, -6} {1,-1}   ", "Month", col + 1);
            }

            Console.WriteLine( );

            Console.Write("{0,-20}    {1,-7}", "  Name", " Sales  ");
            for (int col = 0; col < sales.GetLength(1) - 1; col++)
            {
                Console.Write("{0, 8}   ", inc.ToString("P0"));
                inc += 0.05;
            }
            Console.WriteLine( );
        }

        public static void DisplaySalesProjections(string[ ] salesman, double[ , ] sales)
        {
            string[ ] name = new string[3];

            Console.WriteLine( );
            for (int row = 0; row < sales.GetLength(0); row++)
            {
                name = salesman[row].Split(' ');
                Console.Write("{0, -20}", (name[1] + ", " + name[0]));
                for (int col = 0; col < sales.GetLength(1); col++)
                {
                    Console.Write("{0, 11:N2}", sales[row, col]);
                }
                Console.WriteLine( );
            }
        }
    }
}
