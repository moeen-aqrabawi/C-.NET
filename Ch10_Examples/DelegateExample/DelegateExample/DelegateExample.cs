// DelegateExample.cs         Author: Doyle
// After defining a delegate class, three delegate
// instance are instantiated. Delegates are
// used as arguments for the Show( ) method. 

using System;
using System.Windows.Forms;

namespace DelegateExample
{        
    delegate string ReturnsSimpleString();

    class DelegateExample
    {
        static void Main(string[] args)
        {
            int age = 18;
            ReturnsSimpleString saying1 = new ReturnsSimpleString(AHeading);
            ReturnsSimpleString saying2 = new ReturnsSimpleString((age + 10).ToString);
            ReturnsSimpleString saying3 = new ReturnsSimpleString(EndStatement);

            MessageBox.Show(saying1() + saying2() + saying3());
        }

        // Method that returns a string.
        static string AHeading()
        {
            return "Your age will be ";
        }

        // Method that returns a string.
        static string EndStatement()
        {
            return " in 10 years. ";
        }
    }
}
