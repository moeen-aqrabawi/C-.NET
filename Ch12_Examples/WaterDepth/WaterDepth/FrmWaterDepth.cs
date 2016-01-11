// FrmWaterDepth.cs
// Graphical User Interface class
using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace WaterDepth
{
    public partial class FrmWaterDepth : Form
   {
        private ShoalArea anArea;

        public FrmWaterDepth()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
                        double[ ] lowTides = new double[4];
            double[ ] hiTides = new double[4];
            anArea.Location = txtBxLocation.Text;

            try
            {
                lowTides[0] = double.Parse( txtBxLow1.Text );
                lowTides[1] = double.Parse(txtBxLow2.Text);
                lowTides[2] = double.Parse(txtBxLow3.Text);
                lowTides[3] = double.Parse(txtBxLow4.Text);
                hiTides[0] = double.Parse( txtBxHi1.Text );
                hiTides[1] = double.Parse( txtBxHi2.Text );
                hiTides[2] = double.Parse( txtBxHi3.Text );
                hiTides[3] = double.Parse( txtBxHi4.Text );

                anArea.State = txtBxState.Text;
                anArea.MileMarker = double.Parse( txtBxMile.Text );

                anArea.LoTideDepth = lowTides;
                anArea.HiTideDepth = hiTides;

                MessageBox.Show(anArea.ToString( ), "ICW Problem Area" );

            }

            catch (TestOfStateException ex)
            {
                Trace.WriteLine( "\nException: " + ex.Message );
                lblError.Text += "\nException: " + ex.Message; 
            }

            catch (System.FormatException ex)
            {
                Trace.WriteLine( "Method's actual argument does not match formal parameter." +
                               "\nException: " + ex.Message );
                lblError.Text += "\nException: " + ex.Message; 

            }
            catch (System.ArithmeticException ex)
            {
                Debug.WriteLine( "Errors in an arithmetic, casting, or conversion." +
                                "\nException: " + ex.Message );
                lblError.Text += "\nException: " + ex.Message; 

            }
            catch (System.ArrayTypeMismatchException ex)
            {
                Trace.WriteLine( "Trying to store an element of wrong type in an array." +
                                "\nException: " + ex.Message );
                lblError.Text += "\nException: " + ex.Message; 

            }
            catch (System.IndexOutOfRangeException ex)
            {
                Trace.WriteLine( "Trying to access element of an array with index outside" +
                                 " bounds of the array." +
                                "\nException: " + ex.Message );
                lblError.Text += "\nException: " + ex.Message; 

            }

            catch (System.Exception ex)
            {
                lblError.Text += "\nException: " + ex.Message;
                Trace.WriteLine( "Exception: " + ex.Message );
            }
         }

        private void FrmWaterDepth_Load(object sender, EventArgs e)
        {
            anArea = new ShoalArea();
        }
    }
}
