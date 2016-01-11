// Windows0.cs          Author: Doyle
// Demonstrates creating a blank container form  
using System.Windows.Forms;

namespace Windows0
{
    public  class Form1 : Form
    {
        public Form1( )
        {
            Text = "Simple Windows Application";
        }

        static void Main()
        {
            Form1 winForm = new Form1( );
            Application.Run(winForm);
        }
    }

}
  