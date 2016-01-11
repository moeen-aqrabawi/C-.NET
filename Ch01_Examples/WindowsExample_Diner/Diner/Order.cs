// Order.cs       Author: Doyle
// Creates an order class with 
// entree, drink and special request
// data members. Methods to calculate 
// total cost of order, and set each
// data member included.

using System;
using System.Windows.Forms;
namespace Diner
{
    public class Order
    {
        public string[ ] menuEntree = new
            string[ ] {"Chicken Salad", 
                        "Ham and Cheese",
                        "Turkey", "Vegetable Wrap", 
                        "Tuna Salad", 
                        "Avocado and Cheese", 
                        "Club", "Peanut Butter & Jelly",  
                        "Grilled Cheese", "Reuben" };

        public decimal[ ] menuEntreePrice = new
            decimal[ ] {4.50m, 5.00m, 4.75m, 
                         4.00m, 4.50m, 4.00m, 5.50m, 
                         3.75m, 3.50m, 5.00m };

        private string entree;
        private bool waterSelection;
        private string drinkSelection;
        private string specialRequest;
        private decimal entreePrice;
        private decimal drinkPrice;

        // Default constructor
        public Order( )
        {
            entree = "";
            waterSelection = false;
            specialRequest = "";
            drinkPrice = 0;
            entreePrice = 0;
        }

        // Property for entree
        public string Entree
        {
            get
            {
                return entree;
            }
            set
            {
                entree = value;
                SetEntreePrice( );
            }
        }

        // Property for special requests
        public string SpecialRequest
        {
            get
            {
                return specialRequest;
            }
            set
            {
                specialRequest = value;
            }
        }

        //Property for Waters selection
        public bool WaterSelection
        {
            set
            {
                waterSelection = value;
            }
        }

        //Property for Drink selection
        public string DrinkSelection
        {
            get
            {
                return drinkSelection;
            }
            set
            {
                drinkSelection = value;
                SetDrinkPrice( );
            }
        }

        // Read only property for entree price
        public decimal EntreePrice
        {
            get
            {
                return entreePrice;
            }
        }

        // Read only property for drink price
        public decimal DrinkPrice
        {
            get
            {
                return drinkPrice;
            }
        }

        // Once the entree is set, store the entree price
        public void SetEntreePrice( )
        {
            for (int i = 0; i < menuEntree.Length; i++)
            {
                if (menuEntree[i] == entree)
                {
                    entreePrice = menuEntreePrice[i];

                }
            }
        }

        // Return the water selection
        public string GetWaterSelection( )
        {
            string waterOrNot;
            if (waterSelection)
            {
                waterOrNot = "Water";
            }
            else
            {
                waterOrNot = "No Water";
            }
            return waterOrNot;
        }

        // Once the drink is set, store the drink price
        public void SetDrinkPrice( )
        {
            switch (drinkSelection)
            {
                case "Tea":
                case "Coffee":
                    drinkPrice = 1.50m;
                    break;
                case "Soda":
                case "Lemonade":
                    drinkPrice = 2.00m;
                    break;
                case "Milk":
                case "Juice":
                    drinkPrice = 1.75m;
                    break;
            }
        }

        // Return the total cost of the order
        public decimal DetermineTotalCharges( )
        {
            return entreePrice + drinkPrice;
        }
    }
}