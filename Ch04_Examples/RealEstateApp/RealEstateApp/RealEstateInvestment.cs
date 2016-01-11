/* RealEstateInvestment.cs		
 * Author:	Doyle	
 * This class defines a template
 * for a real estate object to 
 * include instance data members, 
 * public properties,
 * constructors and a method to
 * determine the monthly earnings. 
 */ 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp
{
    class RealEstateInvestment
    {
        private string streetAddress;
        private int yearBuilt;
        private double purchasePrice;
        private double monthlyExpense;
        private double incomeFromRent;

        // Read only property
        public double YearBuilt
        {
            get
            {
                return yearBuilt;
            }
        }

        // Read only property
        public string StreetAddress
        {
            get
            {
                return streetAddress;
            }
        }

        // Read only property
        public double PurchasePrice
        {
            get
            {
                return purchasePrice;
            }
        }

        // Property acting as mutator
        // and accessor
        public double MonthlyExpense
        {
            set
            {
                monthlyExpense = value;
            }
            get
            {
                return monthlyExpense;
            }
        }

        // Property acting as mutator
        // and accessor
        public double IncomeFromRent
        {
            set
            {
                incomeFromRent = value;
            }
            get
            {
                return incomeFromRent;
            }
        }

        // No Default constructor is provided due to the read only data fields
       

        // Three parameter constructor with year listed first
        public RealEstateInvestment(int year, double price, string address)
        {
            yearBuilt = year;
            purchasePrice = price;
            streetAddress = address;
        }

        // Three parameter constructor with address listed first
                public RealEstateInvestment(string address, int year, double price)
        {
            streetAddress = address;
            yearBuilt = year;
            purchasePrice = price;
        }

        // Two parameter constructor with address listed first
        public RealEstateInvestment(string address, int price)
        {
            streetAddress = address;
            purchasePrice = price;
        }

        // Two parameter constructor with price listed first
        public RealEstateInvestment(double price, string address)
        {
            streetAddress = address;
            purchasePrice = price;
        }

    
        // Returns the earnings for a given month
        public double DetermineMonthlyEarnings()
        {

            return incomeFromRent - monthlyExpense;
        }

        public override string ToString()
        {
            return "Location: " + streetAddress +
                //"\nYear Built: " + yearBuilt +   // Year omitted - A constructor is provided without year and year is read only
                    "\nPurchase Price: " + 
                    purchasePrice.ToString("C") +
                    "\nMonthly Income: " + 
                    monthlyExpense.ToString("C") +
                    "\nIncome from Rent: " + 
                    incomeFromRent.ToString("C") +
                    "\nMonthly Earnings: " + 
                    DetermineMonthlyEarnings().ToString("C");
        }
    }
}
