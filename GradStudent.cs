//Jonathan James
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS345_Final_Project
{
    public class GradStudent:Student
    {

        //Auto Implemented Grad only variable
        public int gmatScore
        {
            get
            {
                return gmatScore;
            }
            private set
            {
                if (value > 200 & value < 800)
                    gmatScore = value;
                else
                {
                    MessageBox.Show("Not Smart Enough To Be A Graduate Student");
                }
            }
        } 

        //Variables
        public bool graduateStatus
        {
            get
            {
                return graduateStatus;
            }
            private set
            {
                if (gpa <= 3.0)
                    graduateStatus = true;
                else
                    graduateStatus = false;
            }
        }

        //6 parameter constructor for Graduate students
        public GradStudent(string studentid, string firstName, string lastName, double gpA
            ,int gmatS, bool gradStatus):base( studentid, firstName, lastName, gpA)
        {
            gmatScore = gmatS;  
            graduateStatus = gradStatus;   
        }

        //to string for graduate students
        //return string of student info (most likely written to the data file
        public override string ToString()
        {
            return string.Format("{0}:{1} \r\n{2}: {3}{4} \r\n{5}:{6}   \r\n{7}:{8}   \r\n{9}:{10}",
                "Student ID", studentId,
                "Student Name", FirstName, LastName,
                "GPA", gpa,
                "GMAT Score", gmatScore,
                "Graduate Student", graduateStatus
                );
        }
    }
}
