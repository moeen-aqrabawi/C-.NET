/* PresentationGUI.cs
 * This application added two new
 * classes - all in the same project.
 * Inheritance is illustrated through
 * Student extending Person.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationGUI
{
    public partial class PresentationGUI : Form
    {
        private Student aStudent;

        public PresentationGUI()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            // Uses Age property defined in the Person class
            aStudent.Age = 25;

            // Calls overridden ToString() in Person
            // Returns the first name, a space, and the last name
            txtBxName.Text = aStudent.ToString();

            // Calls ToString( ) from Object
            // Returns a number representing age in string format
            txtBxAge.Text = aStudent.Age.ToString();

            // Uses StudentID property defined in Student class
            txtBxID.Text = aStudent.StudentId;

            // Calls GetSleepAmt( ) defined in Student class
            txtBxStudentSleep.Text = 
                Convert.ToString(aStudent.GetSleepAmt());

            // Calls method defined in Student class that
            // has a call to base.GetSleepAmt( ) in Person class
            txtBxPersonSleep.Text = 
                Convert.ToString(aStudent.CallOverriddenGetSleepAmt());

            // GetExerciseHabits( ) method defined as abstract method in Person
            txtBxExercise.Text = aStudent.GetExerciseHabits();
            btnTravel.Visible = true;
        }

        private void PresentationGUI_Load(object sender, EventArgs e)
        {
            aStudent = new Student("123456789", "Maria", "Woo", "CS", "1111");
        }

        private void btnTravel_Click(object sender, EventArgs e)
        {
            // GetStartLocation( ), GetDestination( ) and
            // DetermineMiles( ) methods all defined as 
            // abstract methods in ITraveler interface
            txtBxFrom.Text = 
                aStudent.GetStartLocation();
            txtBxTo.Text = 
                aStudent.GetDestination();
            txtBxMiles.Text = 
                aStudent.DetermineMiles().ToString();
            txtBxFrom.Visible = true;
            txtBxTo.Visible = true;
            txtBxMiles.Visible = true;
            lblHeading.Visible = true;
            lblMiles.Visible = true;
            lblFrom.Visible = true;
            lblTo.Visible = true;
        }
    }
}
