using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationGUI
{
    class Student : Person
    {
        private string major;
        private string studentId;

        public Student()
            : base()
        {
        }

        // Constructor which sends arguments to base class
        public Student(string id, string fname, string lname, string maj, string sId)
            : base(id, lname, fname)
        {
            major = maj;
            studentId = sId;
        }

        // Read only Property for studentID
        public string StudentId
        {
            get
            {
                return studentId;
            }
        }

        // Property for major data field
        public string Major
        {
            get
            {
                return major;
            }
            set
            {
                major = value;
            }
        }

        // Overrides GetSleepAmt( ) method of the Person class
        public override int GetSleepAmt()
        {
            return 6;
        }

        // Using the base keyword, calls the overridden
        // GetSleepAmt( ) method of the Person class
        public int CallOverriddenGetSleepAmt()
        {
            return base.GetSleepAmt();
        }
    }
}
