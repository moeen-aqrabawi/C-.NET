using System;
using System.Windows.Forms;

namespace ErrorExampleWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Exception thrown if non-numeric data entered
        private void btnCompute_Click(object sender, EventArgs e)
        {
            this.txtBxResult.Text = (int.Parse(this.txtBxValue1.Text) + 
                int.Parse(this.txtBxValue2.Text)).ToString();
        }
    }
}
