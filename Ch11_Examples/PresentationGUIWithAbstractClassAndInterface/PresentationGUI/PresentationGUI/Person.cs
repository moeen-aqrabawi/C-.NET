
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationGUI
{
    public abstract class  Person
    {

        private string idNumber;
        private string lastName;
        private string firstName;
        private int age;

        public Person()   
        {
        }

        public Person(string id, string lname, string fname,
            int anAge)  
        {
            idNumber = id;
            lastName = lname;
            firstName = fname;
            age = anAge;
        }

        public Person(string id, string lname, string fname)
        {               
            idNumber = id;
            lastName = lname;
            firstName = fname;
        }
        public Person(string id)
        {              
            idNumber = id;
        }

        public string IdNumber
        {
            get
            {
                return idNumber;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public override string ToString()
        {
            return firstName + " " + lastName;
        }

        // Virtual method can be overridden 
        // by classes that derive from Person
        public virtual int GetSleepAmt()
        {
            return 8;
        }

        // Classes that derive from Person
        // must provide implementation details
        // (the body for the method)
        public abstract string GetExerciseHabits();
    }
}