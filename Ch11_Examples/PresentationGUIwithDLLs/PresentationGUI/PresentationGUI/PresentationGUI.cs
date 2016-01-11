/* PresentationGUI.cs
 * This application has three separate projects. 
 * The Person.dll and Student.dll were referenced.
 * A using StudentNamespace was added - no need
 * for using PersonNamespace since it is 
 * referenced in Student. 
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
using StudentNamespace;   //Added for Student class

namespace PresentationGUI
{
    public partial class PresentationGUI : Form
    {
        private Student aStudent;

        public PresentationGUI()
        {
            InitializeComponent();
        }

        private void PresentationGUI_Load(object sender, EventArgs e)
        {
            aStudent = new Student("123456789", "Maria", "Woo", "CS", "1111");
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            // Uses Age property defined in the Person class
            aStudent.Age = 25;

            // Calls overridden ToString() defined in Person class
            txtBxName.Text = aStudent.ToString();

            // Calls ToString( ) defined in object class
            txtBxAge.Text = aStudent.Age.ToString(); 

            // Uses StudentID property defined in Student class
            txtBxID.Text = aStudent.StudentId;

            // Calls GetSleepAmt( ) defined in Student class
            txtBxStudentSleep.Text = Convert.ToString(aStudent.GetSleepAmt());

            // Calls method defined in Student class that
            // has a call to base.GetSleepAmt( ) in Person class
            txtBxPersonSleep.Text = Convert.ToString(aStudent.CallOverriddenGetSleepAmt());
        }
    }
}
