/* PhoneApplication     MainPage.xaml
 * Inches to Centimeters Converter.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace PhoneApplication
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void radBtns_Checked(object sender, RoutedEventArgs e)
        {
            if (radBtnInches.IsChecked == true)
                txtBlkOutput.Text = "Result: " +
                    (double.Parse(txtBxInput.Text) * 0.3937008).ToString("F2");
            else
                if (radBtnCent.IsChecked == true)
                    txtBlkOutput.Text = "Result: " +
                        (double.Parse(txtBxInput.Text) * 2.54).ToString("F2");

        }
    }
}