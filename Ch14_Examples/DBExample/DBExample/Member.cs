// Member.cs
// This class includes private members of
// identification number, first and last
// names and local phone number. Read-only
// properties are included. The ToString( )
// method is overridden to return a formatted 
// full name 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBExample
{
    class Member
    {
        private string id;
        private string firstName;
        private string lastName;
        private string phoneNumber;

        public Member()
        {

        }

        // Constructor
        public Member(string fname, string lname)
        {
            firstName = fname;
            lastName = lname;

        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
        }

        public string Id
        {
            get
            {
                return id;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
        }

        public override string ToString()
        {
            return firstName + " " + lastName;
        }
    }
}