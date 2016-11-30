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
    public partial class FinalSchedule : Form
    {
        public FinalSchedule()
        {
            InitializeComponent();
        }

        private void back_to_menu_Click(object sender, EventArgs e)
        {
            MenuForm menu = new MenuForm();

            //Back to the Menu
            menu.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {       
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader("Students.txt"))
                {
                    // Read the stream to a string, and write the string to the console.
                    String line = sr.ReadToEnd();
                    textBox1.Text = line;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
    