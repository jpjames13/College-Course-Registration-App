//Jonathan P James
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS345_Final_Project
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void finalSButton_Click(object sender, EventArgs e)
        {
            FinalSchedule showFinalSchedule = new FinalSchedule();

            //show the final schedule form
            showFinalSchedule.Show();

            this.Hide();
        }

        private void editCourse_Click(object sender, EventArgs e)
        {
            Courses showCourseForm = new Courses();

            //show the course form
            showCourseForm.Show();
            
            this.Hide();
        }

        private void addStudent_Click(object sender, EventArgs e)
        {
            EditStudentInfo showEditStudentInfo = new EditStudentInfo();
            
            //show the edit student form
            showEditStudentInfo.Show();

            this.Hide();
        }
    }
}
