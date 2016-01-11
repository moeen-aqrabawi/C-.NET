/* CarpetCalculator.cs
* Author: Doyle
* Defines the template for the
* CarpetCalculator class to include constructors,
* accessors, mutators, and properties
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpetCalculatorApp
{
    public class CarpetCalculator
    {
        private double pricePerSqYard;
        private double noOfSqYards;

        // Property of the pricePerSqYard data field
        public double PricePerSqYard
        {
            get
            {
                return pricePerSqYard;
            }
            set
            {
                pricePerSqYard = value;
            }
        }

        // Property also associated with
        // pricePerSqYard - works but does
        // not follow naming convention
        public double Price
        {
            get
            {
                return pricePerSqYard;
            }
            set
            {
                pricePerSqYard = value;
            }
        }

        // Property for noOfSqYards data field
        public double NoOfSqYards
        {
            get
            {
                return noOfSqYards;
            }
            set
            {
                noOfSqYards = value;
            }
        }

        // Default Constructor
        public CarpetCalculator()
        {
            //empty body
        } 
       
        // One argument constructor
        public CarpetCalculator(double price)
        {

            pricePerSqYard = price;
        }

        // Two argument constructor
        public CarpetCalculator(double amountNeeded, double price)
        {
            noOfSqYards = amountNeeded;
            pricePerSqYard = price;
        }

        public double DetermineTotalCost()
        {
            return (pricePerSqYard * noOfSqYards);
        }

        // One of the overloaded Mutator methods
        public void SetNoOfSqYards(double length,
                                        double width)
        {
            const int SQ_FT_PER_SQ_YARD = 9;

            noOfSqYards = length * width
                / SQ_FT_PER_SQ_YARD;
        }

        // One of the overloaded Mutator methods
        public void SetNoOfSqYards(double squareYards)
        {
            noOfSqYards = squareYards;
        }

        // Accessor method
        public double GetNoOfSqYards()
        {
            return noOfSqYards;
        }

        public override string ToString()
        {
            return "Price Per Square Yard: " +
                   pricePerSqYard.ToString("C") +
                   "\nTotal Square Yards: " +
                   noOfSqYards.ToString("F1") +
                   "\nTotal Price: " +
                   DetermineTotalCost().ToString("C");
        }

    }
}
