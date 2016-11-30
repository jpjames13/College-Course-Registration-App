//Jonathan James
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS345_Final_Project
{
    class Course
    {
        //varibles
        int maxCredits = 18;
        Course[] prerequisites = new Course[10]; //if student has taken class 
                                                 //add that class to prequisite
                                                 //check through for loop if prereq
                                                 //is met


        //Auto implemented properties
        public string subject  { get; private set; }
        public string days { get; private set; }
        public string courseTitle { get; set; }
        public int courseNumber { get; private set; }
        public int unitNum { get; private set; }
        public double startTime { get; private set; }

        //autoimplemented course array
        public Course[] prerequisite
        {
            get { return prerequisites; }
            private set
            {
                if(value != null)
                {
                    prerequisites = value;
                }
            }
        }
        

        // 6 number parameter constructor
        public Course(string Subject, string cTitle, int courseNum, int unitnum, string DAYS,double StartTimes)
        {
            subject = Subject;
            courseTitle = courseTitle;
            courseNumber = courseNum;
            unitNum = unitnum;
            days = DAYS;
            startTime = StartTimes;           
        }

       
    }
}

