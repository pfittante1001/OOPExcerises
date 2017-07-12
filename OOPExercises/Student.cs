using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercises
{
    class Student
    {
        //fields

        private string firstName;
        private string middleName;
        private string lastName;
        private string courseName;
        private string univName;
        private string course;
        private int courseNumber;
        private string emailAdd;
        private string phoneNumber;

        //Properties

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string MiddleName
        {
            get { return this.middleName; }
            set { this.middleName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public string CourseName
        {
            get { return this.courseName; }
            set { this.courseName = value; }
        }

        public string UnivName
        {
            get { return this.univName; }
            set { this.univName = value; }
        }

        public string Course
        {
            get { return this.course; }
            set { this.course = value; }
        }

        public int CourseNumber
        {
            get { return this.courseNumber; }
            set { this.courseNumber = value; }
        }

        public string EmailAdd
        {
            get { return this.emailAdd; }
            set { this.emailAdd = value; }
        }

        public string PhoneNumber
        {
            get { return this.phoneNumber; }
            set { this.phoneNumber = value; }
        }

        //Constructors

        public Student()
        {
            //default constructor
        }

        public Student(string firstNameST,string middleNameST, string lastNameSt, string courseNameST, string univNameST, string courseSt,
                        int courseNumberSt, string emailAddST, string phoneNumberST)
        {
            this.firstName = firstNameST;
            this.middleName = middleNameST;
            this.lastName = lastNameSt;
            this.courseName = courseNameST;
            this.univName = univNameST;
            this.course = courseSt;
            this.courseNumber = courseNumberSt;
            this.emailAdd = emailAddST;
            this.phoneNumber = phoneNumberST;
        }

        public Student(string firstNameST, string middleNameST, string lastNameSt)
        {
            this.firstName = firstNameST;
            this.middleName = middleNameST;
            this.lastName = lastNameSt;
        }

        public Student(string emailAddST, string phoneNumberST)
        {
            this.emailAdd = emailAddST;
            this.phoneNumber = phoneNumberST;
        }

        public Student(string phoneNumberST)
        {
            this.phoneNumber = phoneNumberST;
            
        }

        public Student(string courseNameST, string univNameST, string courseSt, int courseNumberSt)
        {
            this.univName = univNameST;
            this.course = courseSt;
            this.courseNumber = courseNumberSt;
        }

        public void StudentInfo()
        {
            Console.WriteLine("The students name is {0} {1} {2}", this.FirstName, this.MiddleName, this.LastName);
            Console.WriteLine("The students email address is {0}", this.EmailAdd);
            Console.WriteLine("The students phone number is {0}", this.PhoneNumber);
        }
    }
}