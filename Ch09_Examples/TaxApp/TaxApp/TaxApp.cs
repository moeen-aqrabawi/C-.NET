/* TaxApp.cs             Author: Doyle
 * A Tax calculator is produced. Labels are used 
 * to display descriptive captions. A textbox 
 * object is used for input and displaying results. 
 * One button click event method is programmed.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxApp
{
    static class TaxApp
    {
        // The main entry point for the application.
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
