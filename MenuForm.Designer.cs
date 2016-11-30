namespace CIS345_Final_Project
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.finalSButton = new System.Windows.Forms.Button();
            this.studentRegisMenulbl = new System.Windows.Forms.Label();
            this.addStudent = new System.Windows.Forms.Button();
            this.editCourse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // finalSButton
            // 
            this.finalSButton.Location = new System.Drawing.Point(34, 132);
            this.finalSButton.Name = "finalSButton";
            this.finalSButton.Size = new System.Drawing.Size(134, 23);
            this.finalSButton.TabIndex = 0;
            this.finalSButton.Text = "View Final Schedule";
            this.finalSButton.UseVisualStyleBackColor = true;
            this.finalSButton.Click += new System.EventHandler(this.finalSButton_Click);
            // 
            // studentRegisMenulbl
            // 
            this.studentRegisMenulbl.AutoSize = true;
            this.studentRegisMenulbl.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentRegisMenulbl.Location = new System.Drawing.Point(44, 40);
            this.studentRegisMenulbl.Name = "studentRegisMenulbl";
            this.studentRegisMenulbl.Size = new System.Drawing.Size(379, 29);
            this.studentRegisMenulbl.TabIndex = 4;
            this.studentRegisMenulbl.Text = "Student Registration Application";
            // 
            // addStudent
            // 
            this.addStudent.Location = new System.Drawing.Point(314, 132);
            this.addStudent.Name = "addStudent";
            this.addStudent.Size = new System.Drawing.Size(134, 23);
            this.addStudent.TabIndex = 5;
            this.addStudent.Text = "Add Student";
            this.addStudent.UseVisualStyleBackColor = true;
            this.addStudent.Click += new System.EventHandler(this.addStudent_Click);
            // 
            // editCourse
            // 
            this.editCourse.Location = new System.Drawing.Point(174, 132);
            this.editCourse.Name = "editCourse";
            this.editCourse.Size = new System.Drawing.Size(134, 23);
            this.editCourse.TabIndex = 6;
            this.editCourse.Text = "Edit Course";
            this.editCourse.UseVisualStyleBackColor = true;
            this.editCourse.Click += new System.EventHandler(this.editCourse_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 255);
            this.Controls.Add(this.editCourse);
            this.Controls.Add(this.addStudent);
            this.Controls.Add(this.studentRegisMenulbl);
            this.Controls.Add(this.finalSButton);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button finalSButton;
        private System.Windows.Forms.Label studentRegisMenulbl;
        private System.Windows.Forms.Button addStudent;
        private System.Windows.Forms.Button editCourse;
    }
}