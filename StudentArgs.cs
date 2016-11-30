//Jonathan James
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS345_Final_Project
{
    public class StudentArgs:EventArgs
    {
        public Student Students
        { get; set; }

        public GradStudent GradStudents
        { get; set; }
    }
}
