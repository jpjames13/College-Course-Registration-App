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
    public partial class Courses : Form
    {
        public Courses()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            




            //After course is added return to the menu
            MenuForm menu = new MenuForm();

            //Show Menu
            menu.Show();

            //Then Hide this form
            this.Hide();
        }




        //list all customers from assignment 6
        ////display the customers
        //public void displayCustomers(List<Customer> list)
        //{
        //    //loop thru the array and display all the data
        //    foreach (Customer customer in list)
        //    {
        //        if (customer != null)
        //        {
        //            customerListBox.Items.Add(customer);
        //        }
        //    }
        //}//end displayCustomers method
    }
}
