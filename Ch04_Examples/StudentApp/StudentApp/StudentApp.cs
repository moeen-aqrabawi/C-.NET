using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    class StudentApp
    {
        static void Main(string[] args)
        {
            Student firstStudentObject = new Student();
          
            firstStudentObject.StudentLastName = AskForStudentName("Last");
            firstStudentObject.StudentFirstName = AskForStudentName("First");
            firstStudentObject.StudentNumber = AskForStudentNumber();
            firstStudentObject.Major = AskForMajor(firstStudentObject.StudentFirstName);
            firstStudentObject.Score1 = AskForExamScore(1);
            firstStudentObject.Score2 = AskForExamScore(2);
            firstStudentObject.Score3 = AskForExamScore(3);

            Console.Clear();
            Console.WriteLine("First Student");
            Console.WriteLine(firstStudentObject.ToString());


            Student secondStudentObject = new Student("2345");
            secondStudentObject.Score1 = 95;
            secondStudentObject.Score2 = 62;
            secondStudentObject.Score3 = 87;
            Console.WriteLine("\n\nSecond Student");
            Console.WriteLine("Student Number: " + secondStudentObject.StudentNumber +
                               "\nAverage: {0:F1}", secondStudentObject.CalculateAverage());


            Student thirdStudentObject = new Student("5432", "Randolph",  "Wonder");
            thirdStudentObject.Major = "Math";
            thirdStudentObject.Score1 = 95;
            thirdStudentObject.Score2 = 87;
            thirdStudentObject.Score3 = 72;
            Console.WriteLine("\n\nThird Student");
            Console.WriteLine(thirdStudentObject);


            Student aStudentObject = new Student("1234", "Maria", "Smith", 97, 75, 87, "CS");
            Console.WriteLine("\n\nLast Student");
            Console.WriteLine("Student Name: " + aStudentObject.StudentFirstName +
                              " " + aStudentObject.StudentLastName +
                              "\nStudent Number: " + aStudentObject.StudentNumber +
                              "\nMajor: " + aStudentObject.Major +
                              "\nExam Score 1: " + aStudentObject.Score1 +
                              "\nExam Score 2: " + aStudentObject.Score2 +
                              "\nExam Score 3: " + aStudentObject.Score3 +
                              "\nExam Average: " + aStudentObject.CalculateAverage().ToString("F1"));
            Console.ReadKey();
        }

        public static int AskForExamScore(int whichOne)
        {
            string inValue;
            int aScore;
            Console.Write("Enter a value for Score {0}: ", whichOne);
            inValue = Console.ReadLine();
            aScore = int.Parse(inValue);
            return aScore;
        }

        public static string AskForStudentName(string whichOne)
        {
            string inValue;
            Console.Write("Enter Student {0} Name: ", whichOne);
            inValue = Console.ReadLine();
            return inValue;
        }
        public static string AskForMajor(string name)
        {
            string inValue;
            Console.Write("Enter {0}\'s Major: ", name);
            inValue = Console.ReadLine();
            return inValue;
        }
        public static string AskForStudentNumber()
        {
            string inValue;
            Console.Write("Enter Student Number: ");
            inValue = Console.ReadLine();
            return inValue;
        }
    }
}