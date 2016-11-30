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
using System.IO;

namespace CIS345_Final_Project
{
    public partial class EditStudentInfo : Form
    {
        //Declaring public events named AddStudent and AddGradStudent usign the NewStudent Delegate
        public event NewStudent AddStudent;
        public event NewStudent AddGradStudent;

        //Form Constructor
        public EditStudentInfo()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {


            try
            {
                if (gmatTxbx.Visible == false)
                {
                    //Creating the student object to be added to the list
                    Student studentObj = new Student(idBx.Text, fnameBx.Text, lnameBx.Text, Convert.ToDouble(gpaBx.Text));

                    //Creating StudentArgs object
                    StudentArgs StudentArgs = new StudentArgs();

                    //assigning student object to the student args object
                    StudentArgs.Students = studentObj;

                    //Invoker
                    AddStudent(this, StudentArgs);
                }
                else
                {
                    //Creating GradStudent Object
                    GradStudent gradStudentObj = new GradStudent(idBx.Text, fnameBx.Text, lnameBx.Text, Convert.ToDouble(gpaBx.Text), Convert.ToInt32(gmatTxbx.Text), true);

                    //Creating GradStudentArgs object
                    StudentArgs StudentArgs = new StudentArgs();

                    //assigning gradstudent object to the student args object
                    StudentArgs.GradStudents = gradStudentObj;

                    //Invoker
                    AddGradStudent(this, StudentArgs);

                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
            catch (IOException ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
            catch (SystemException ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
            finally
            {
                //After course is added return to the menu
                MenuForm menu = new MenuForm();

                //Show Menu
                menu.Show();

                //Close this Form
                this.Close();
            }
        }
        private void yesBtn_CheckedChanged(object sender, EventArgs e)
        {
            //please don't mess with the radio buttons
            //the Gmat option becomes visible
            if (gmatLbl.Visible == false)
            {
                gmatLbl.Visible = true;
                gmatTxbx.Visible = true;
            }

        }

        private void noBtn_CheckedChanged(object sender, EventArgs e)
        {
            //the Gmat option becomes invisible
            gmatLbl.Visible = false;
            gmatTxbx.Visible = false;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {


            //MessageBox.Show("I tried");

            //Creating the filestreams to write to file
            FileStream fsStudents = new FileStream("Students.txt", FileMode.Create, FileAccess.Write);
            StreamWriter swStudents = new StreamWriter(fsStudents);
            //TextWriter twStudents = new StreamWriter("Students.txt", true);

            try
            {
                if (gmatTxbx.Visible == false)
                {
                    //Creating the student object to be added to the list
                    Student studentObj = new Student(idBx.Text, fnameBx.Text, lnameBx.Text, Convert.ToDouble(gpaBx.Text));

                    ////Creating StudentArgs object
                    //StudentArgs StudentArgs = new StudentArgs();

                    ////assigning student object to the student args object
                    //StudentArgs.Students = studentObj;

                    ////Invoker
                    //AddStudent(this, StudentArgs);


                    swStudents.WriteLine(studentObj.ToString());

                    //foreach (var item in studentObj.ToString())
                    //{
                    //    if (item != null)
                    //    {
                    //        swStudents.Write(item + ',');
                    //    }
                    //}
                }
                else
                {


                    //Creating GradStudent Object
                    GradStudent gradStudentObj = new GradStudent(idBx.Text, fnameBx.Text, lnameBx.Text, Convert.ToDouble(gpaBx.Text), Convert.ToInt32(gmatTxbx.Text), true);

                    ////Creating GradStudentArgs object
                    //StudentArgs StudentArgs = new StudentArgs();

                    ////assigning gradstudent object to the student args object
                    //StudentArgs.GradStudents = gradStudentObj;

                    ////Invoker
                    //AddGradStudent(this, StudentArgs);

                    swStudents.WriteLine(gradStudentObj.ToString());

                    //foreach (var item in gradStudentObj.ToString())
                    //{
                    //    if (item != null)
                    //    {
                    //        swStudents.WriteLine(item + ',');
                    //    }
                    //}
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
            catch (IOException ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
            catch (SystemException ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
            finally
            {
                //Closing the filestreams
                //twStudents.Close();
                swStudents.Close();
                fsStudents.Close();

                //After course is added return to the menu
                MenuForm menu = new MenuForm();

                //Show Menu
                menu.Show();

                //Close this Form
                this.Close();
            }
        }
    }
}

