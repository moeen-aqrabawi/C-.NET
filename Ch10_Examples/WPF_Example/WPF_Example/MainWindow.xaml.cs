// WPF_Example.xaml             Author: Doyle
// CheckBox and RadioButton objects added to the Windows form.
// Illustrates wiring several methods to the same event handler.

using System.Windows;

namespace WPF_Example
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComputeCharges(object sender, RoutedEventArgs e)
        {
            decimal cost = 0M;
            if (this.ckBxSwim.IsChecked == true)
                cost += 50;
            if (this.ckBxSnorkel.IsChecked == true)
                cost += 25;
            if (this.ckBxDive.IsChecked == true)
                cost += 100;

            if (radAdvanced.IsChecked == true)
            {
                cost -= 15;
                this.lblMsg.Content = "Advanced  –  Discount" +
                      "  $15";
            }
            else
                if (this.radBeginner.IsChecked == true)
                {
                    cost += 10;
                    this.lblMsg.Content = "Beginner  —  Extra  $10" +
                      "  charge";
                }
                else
                    if (radInterm.IsChecked == true)
                    {
                        this.lblMsg.Content = "  ";
                    }

            this.txtBxResult.Text  =  cost.ToString("C");
        }
    }
}
