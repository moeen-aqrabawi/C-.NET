// FrmWaterDepth.cs
// This class defines the Graphical 
// User Interface class. Values retrieved 
// from the user are stored in a text file. 
// If you want to append data onto the end
// of the file, copy WaterDepth_bak.txt file to
// WaterDepth.txt, which is stored in the
// bin directory.
using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace WaterDepth
{
    public partial class FrmWaterDepth : Form
   {
        private ShoalArea anArea;
        private StreamWriter fil;

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

                StoreDataInFile(anArea);
                MessageBox.Show(anArea.ToString( ), "ICW Problem Area" );
                ClearForm();
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

            try
            {
                fil = new StreamWriter("WaterData.txt");
                //// To append data onto the end of the file,
                //// as opposed to creating a new file, 
                //// add true as the 2nd argument
                //fil = new StreamWriter("WaterData.txt", true);
            }
            catch (DirectoryNotFoundException exc)
            {
                lblError.Text = "Invalid directory"
                        + exc.Message;
            }
            catch (System.IO.IOException exc)
            {
                lblError.Text = exc.Message;
            }
        }

        private void StoreDataInFile(ShoalArea anArea)
        {
            try
            {
                fil.WriteLine(anArea.ShoalAreaRecord);
            }
            catch (DirectoryNotFoundException exc)
            {
                lblError.Text = "Invalid directory"
                        + exc.Message;
            }
            catch (InvalidDataException exc)
            {
                lblError.Text = "Invalid format in data stream"
                        + exc.Message;
            }
            catch (System.IO.IOException exc)
            {
                lblError.Text = exc.Message;
            }
        }

        private void FrmWaterDepth_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                fil.Close();
            }
            catch (IOException exc)
            {
                lblError.Text = exc.Message;
            }
        }

        public void ClearForm()
        {
            txtBxLocation.Text = string.Empty;
            txtBxState.Text = string.Empty;
            txtBxMile.Text = string.Empty;
            txtBxLow1.Text = string.Empty;
            txtBxLow2.Text = string.Empty;
            txtBxLow3.Text = string.Empty;
            txtBxLow4.Text = string.Empty;
            txtBxHi1.Text = string.Empty;
            txtBxHi2.Text = string.Empty;
            txtBxHi3.Text = string.Empty;
            txtBxHi4.Text = string.Empty;
            lblError.Text = string.Empty;
            txtBxLocation.Focus();
        }
   }
}