// OrderGUI.cs       Author: Doyle
// This file contains the event handler methods.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Diner
{
    public partial class OrderGUI : Form
    {
        public OrderGUI( )
        {
            InitializeComponent( );
        }
        // Instantiates an object of the order class when
        // the form is first loaded.
        private void Form1_Load( object sender, System.EventArgs e )
        {
            newOrder = new Order( );
            for (int i = 0; i < newOrder.menuEntree.Length; i++)
            {
                this.lstBoxEntree.Items.Add
                    ( newOrder.menuEntree[i] );
            }

        }

        // Event handler that gets the entree from the listbox
        // and sets the entree price of the Order object.
        private void lstBoxEntree_SelectedIndexChanged
                           ( object sender, System.EventArgs e )
        {
            newOrder.Entree = this.lstBoxEntree.Text;
        }

        // Event handler that gets the special request -
        // if one is selected from the predefined list.
        private void cmboBoxSpecial_SelectedIndexChanged
                           ( object sender, System.EventArgs e )
        {
            newOrder.SpecialRequest = this.cmboBoxSpecial.Text;
        }

        // Menu item that displays the order. 
        private void menuDisplayOrder_Click( object sender,
                                            System.EventArgs e )
        {
            MessageBox.Show
                ( newOrder.Entree + "\n"
                                 + newOrder.SpecialRequest
                                 + "\n" + newOrder.DrinkSelection
                                 + "\n"
                                 + newOrder.GetWaterSelection( ),
                 "Current Order" );
        }

        // Event handler that gets the radio button selected and
        // sets the drink selection for the Order object
        private void Drink_CheckedChanged( object sender,
                                          System.EventArgs e )
        {
            if (this.radTea.Checked)
                newOrder.DrinkSelection = radTea.Text;
            else
                if (this.radCoffee.Checked)
                    newOrder.DrinkSelection = radCoffee.Text;
                else
                    if (this.radSoda.Checked)
                        newOrder.DrinkSelection = radSoda.Text;
                    else
                        if (this.radLemon.Checked)
                            newOrder.DrinkSelection = radLemon.Text;
                        else
                            if (this.radJuice.Checked)
                                newOrder.DrinkSelection = radJuice.Text;
                            else
                                if (this.radMilk.Checked)
                                    newOrder.DrinkSelection = radMilk.Text;
        }

        // Event handler that gets raised when the check box
        // for the Water gets clicked.
        private void ckBoxWater_CheckedChanged
                          ( object sender, System.EventArgs e )
        {
            if (this.ckBoxWater.Checked)
                newOrder.WaterSelection = true;
            else
                newOrder.WaterSelection = false;
        }
              
       
        // Event handler that gets raised when the Edit menu 
        // is clicked to change the entree.
        private void menuEditEntree_Click
                           ( object sender, System.EventArgs e )
        {
            MessageBox.Show( "Please select a new Entree" );
            newOrder.Entree = "";
            this.lstBoxEntree.ClearSelected( );
        }

        // Event handler that gets raised when the Edit menu 
        // is clicked to change the drink.
        private void menuEditDrink_Click
                           ( object sender, System.EventArgs e )
        {
            MessageBox.Show( "Please select a new Drink" );
            newOrder.DrinkSelection = "";
            this.ClearDrinks( );
        }

        // Clears selections for all drink radio buttons. 
        public void ClearDrinks( )
        {
            this.radMilk.Checked = false;
            this.radJuice.Checked = false;
            this.radSoda.Checked = false;
            this.radLemon.Checked = false;
            this.radTea.Checked = false;
            this.radCoffee.Checked = false;
        }

        //  Clears all selections so that a new order 
        //  can be placed. Resets the Order object back 
        //  to its default values.
        private void menuClearOrder_Click
                           ( object sender, System.EventArgs e )
        {
            this.lstBoxEntree.ClearSelected( );
            this.ckBoxWater.Checked = false;
            this.cmboBoxSpecial.SelectedIndex = -1;
            this.cmboBoxSpecial.Text = "";
            this.ClearDrinks( );
            newOrder.DrinkSelection = "";
            newOrder.Entree = "";
            newOrder.SpecialRequest = "";
            newOrder.WaterSelection = false;
        }

        // Displays the values for the current instance of
        // Order object members
        private void menuPlaceOrder_Click( object sender,
                                  System.EventArgs e )
        {
            MessageBox.Show( newOrder.Entree + "\n" +
                  newOrder.SpecialRequest + "\n" +
                  newOrder.DrinkSelection + "\n" +
                  newOrder.GetWaterSelection( ) +
                  "\n\n\n" + "Total: " +
                  newOrder.DetermineTotalCharges( ).ToString( "C" ),
              "Placed Order" );
        }

        // Event handler that gets raised when the Edit menu 
        // is clicked to change the special requests.
        private void menuEditSpecial_Click( object sender,
                                             System.EventArgs e )
        {
            MessageBox.Show( "Special Request cleared." );
            newOrder.SpecialRequest = "";
            this.cmboBoxSpecial.SelectedIndex = -1;
            this.cmboBoxSpecial.Text = "";
            newOrder.SpecialRequest = "";
        }

        // Event handler that gets raised when the Help 
        // menu is clicked to show the About message.
        private void menuAbout_Click( object sender,
                                       System.EventArgs e )
        {
            MessageBox.Show( "Student Union -" +
                            " Diner by the Valley" +
                            "\n\n\nVersion 1.0" );
        }

        // Event handler that gets raised when the 
        // Exit is clicked
        private void menuExit_Click( object sender,
                                      System.EventArgs e )
        {
            Application.Exit( );
        }

        // Event handler that gets raised when the user types
        // values into the text area of the combo box.
        private void cmboBoxSpecial_KeyPress(object sender, EventArgs e)
        {
            newOrder.SpecialRequest = this.cmboBoxSpecial.Text;
        }
    }
}