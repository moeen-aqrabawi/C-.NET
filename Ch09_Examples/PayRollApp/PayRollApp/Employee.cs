/* Employee.cs          Author: Doyle
 * Employee class includes data characteristics of
 * name, employee number, number of dependents and
 * number of hours worked. Methods calculate
 * deductions for social security, federal tax, and 
 * agency fee. Both Gross and Net Pay are returned.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRollApp
{
    class Employee
    {
        private string employeeFirstName;
        private string employeeLastName;
        private int noOfDependents;
        private double noOfHours;

        //Default constructor	
        public Employee()
        {

        }

        public Employee(string first, string last, 
                          int dep, double hours)
        {
            employeeFirstName = first;
            employeeLastName = last;
            noOfDependents = dep;
            noOfHours = hours;
        }

        public Employee(string first, string last)
        {
            employeeFirstName = first;
            employeeLastName = last;
        }

        public Employee(string first, string last,
                          int dep)
        {
            employeeFirstName = first;
            employeeLastName = last;
            noOfDependents = dep;
        }

        //Property used to access or change Employee First Name
        public string EmployeeFirstName
        {
            set
            {
                employeeFirstName = value;
            }
            get
            {
                return employeeFirstName;
            }
        }

        //Property used to access or change Employee Last Name
        public string EmployeeLastName
        {
            set
            {
                employeeLastName = value;
            }
            get
            {
                return employeeLastName;
            }
        }

        //Property used to access number of dependents
        public int NoOfDependents
        {
            set
            {
                noOfDependents = value;
            }
            get
            {
                return noOfDependents;
            }
        }

        //Property used to access or change hours worked
        public double NoOfHours
        {
            set
            {
                noOfHours = value;
            }
            get
            {
                return noOfHours;
            }
        }

        //Using the same constant value for a flat hourly rate, 
        //calculate gross pay prior to any deductions
        public double DetermineGross()
        {
            const double RATE = 150.00;
            return noOfHours * RATE;
        }

        //Using the same constant value for the Commission Rate
        //for all employees, calculate commission due employee
        public double DetermineAgencyFee()
        {
            const double AGENCY_CHARGE = 0.13;
            return DetermineGross() * AGENCY_CHARGE;
        }

        //Calculate federal tax due
        public double DetermineFederalTax()
        {
            const double FEDERAL_TAX = 0.25;
            const double DEPENDENT_ALLOWANCE = 0.0575;
            double gross;
            gross = DetermineGross();
            return (gross - (gross * 
                (DEPENDENT_ALLOWANCE * noOfDependents))) * FEDERAL_TAX;
        }

        //Calculate Social Security taxes
        public double DetermineSocialSecurity()
        {
            const double SOCIAL_SECURITY_RATE = 0.0785;
            return DetermineGross() * SOCIAL_SECURITY_RATE;
        }

        public double DetermineNet()
        {
             return DetermineGross() - DetermineSocialSecurity() -
                DetermineFederalTax() - DetermineAgencyFee();
        }

        public override string ToString()
        {
            return employeeFirstName + " " + employeeLastName +
                "\nTake Home Pay: " + DetermineNet().ToString("C");
        }
    }
}
    