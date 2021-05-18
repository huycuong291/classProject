using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classProject
{
    public partial class AddCourseForm : Form
    {
        public AddCourseForm()
        {
            InitializeComponent();
        }

        private void AF_id_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32( courseID.Text);
            string courseLabel = courseLabel_txt.Text;
            int hours = (int)numericUpDownHours.Value;
            string description = description_txt.Text;
            COURSE course = new COURSE();
                if (courseLabel.Trim() == "")
            {
                MessageBox.Show("error!!! Add course name!!");
            }
                else
            {
                if (course.insertCourse(id,courseLabel, hours, description))
                {
                    MessageBox.Show("Done!");
                    
                }
                else
                {
                    MessageBox.Show("error!!");
                }
            }
        }
    }
}
