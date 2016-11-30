//Jonathan P James
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS345_Final_Project
{
    public class Student
    {
        //Variables
        string studentid;
        double GPA;

       //Properties and Variables
        public string studentId
        {
            get { return studentid; }  //Get will return this student ID
            private set
            {
                if (value.Length == 10)
                    studentid = value;
                else
                    MessageBox.Show("You have entered an Invalid Entry");
            }
        }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        //The gpa cannot be less than 0 and cannot be more than 4.00  (ain't got no time for 4.3 asu stuff here)
        public double gpa {
            get
            {
                return GPA;
            }
            private set
            {
                if (value > 0 && value < 4.00)
                    GPA = value;
            }
        }


        //Note that gmatScore and graduateStatus should be inherited
        //By graduate student class, because those variables are Graduate
        //student only variables

        //constructors need to be the same name or it will ask for a return type
        //cause it thinks that it's a method instead.
        // 4 parameter constructer
        public Student( string studentid, string firstName, string lastName, double gpA)
        {
            this.studentId = studentid; //fixed
            this.FirstName = firstName;
            this.LastName = lastName;
            this.gpa = gpA;            
        }

        //return string of student info (most likely written to the data file
        public override string ToString()
        {
            return string.Format("{0}:{1} \r\n{2}: {3}{4} \r\n{5}:{6}",
                "Student ID", studentId,
                "Student Name", FirstName, LastName,
                "GPA", gpa);
        }


    }
}


