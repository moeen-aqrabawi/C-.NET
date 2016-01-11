/*SquaredValues.cs   Author: Doyle
 * Displays values 1 through 10
 * along with their squares. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SquaredValues
{
    class SquaredValues
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string result = "\tn       Squared\n";
            while (counter < 10)
            {
                counter++;
                result += " \t"
                       + counter
                       + " \t"
                       + Math.Pow(counter, 2)
                       + "\n";

            }
            MessageBox.Show(result, "1 - 10 and their "
                                     + "squares"
                 , MessageBoxButtons.YesNoCancel
                , MessageBoxIcon.Information
                           );
        }
    }
}
