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
    public partial class manageCourse : Form
    {
        public manageCourse()
        {
            InitializeComponent();
        }
        COURSE course = new COURSE();
        int pos;
        private void manageCourse_Load(object sender, EventArgs e)
        {
            reloadListBox();
        }

        void reloadListBox()
        {
            listBoxCourse.DataSource = course.getAllCourse();
            listBoxCourse.ValueMember = "id";
            listBoxCourse.DisplayMember = "label";
            listBoxCourse.SelectedItem = null ;

            totalCourseLabel.Text = ("Total Course: " + course.totalCourse());
        }


        void showData( int index)
        {
            try
            {
                DataRow dr = course.getAllCourse().Rows[index];
                listBoxCourse.SelectedIndex = index;
                courseID.Text = dr.ItemArray[0].ToString();
                courseLabel_txt.Text = dr.ItemArray[1].ToString();
                numericUpDownHours.Value = int.Parse(dr.ItemArray[2].ToString());
                description_txt.Text = dr.ItemArray[3].ToString();
            }
            catch { }
           
        }



        private void addButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(courseID.Text);
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
                if (course.insertCourse(id, courseLabel, hours, description))
                {
                    MessageBox.Show("Successful to add course !");
                    this.reloadListBox();
                }
                else
                {
                    MessageBox.Show("error!! Cant add course");
                }
            }
        }

        private void listBoxCourse_Click(object sender, EventArgs e)
        {
            DataRowView drv= (DataRowView)listBoxCourse.SelectedItem;
            pos = listBoxCourse.SelectedIndex;
            showData(pos);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            COURSE CRS = new COURSE();
            string id = courseLabel_txt.Text;
            if (MessageBox.Show("Are you sure?", "Delete course", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (CRS.deleteCourse(id))
                {

                    MessageBox.Show("Successful to delete course !", "Delete course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    courseLabel_txt.Text = "";
                    courseID.Text = "";
                    description_txt.Text = "";
                    numericUpDownHours.Value = 0;
                    this.reloadListBox();
                }
                else
                {
                    MessageBox.Show("Error!", "Delete course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            string name = courseLabel_txt.Text;
            int hour = (int)numericUpDownHours.Value;
            string desc = description_txt.Text;
            int id = Convert.ToInt32(courseID.Text);
            COURSE course = new COURSE();
            if (courseLabel_txt.Text.Trim() == "")
            {
                MessageBox.Show("error!!! Course name is null!!");
            }
            else
            {
                if (course.updateCourse(id, name, hour, desc))
                {
                    MessageBox.Show("Successful to edit course !");
                    this.reloadListBox();
                }
                else
                {
                    MessageBox.Show("error!!");
                }
            }
        }

        private void firstButton_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)listBoxCourse.SelectedItem;
            pos = listBoxCourse.TopIndex;
            showData(pos);
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)listBoxCourse.SelectedItem;
            pos = listBoxCourse.SelectedIndex;
            if (pos == listBoxCourse.TopIndex)
            {
                pos = course.getAllCourse().Rows.Count - 1;
            }
            else
            {
                pos -= 1;
            }
       
            showData(pos);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)listBoxCourse.SelectedItem;
            pos = listBoxCourse.SelectedIndex;
            if (pos == course.getAllCourse().Rows.Count - 1)
            {
                pos = listBoxCourse.TopIndex;
            }
            else
            {
                pos += 1;
            }
            showData(pos);
        }

        private void endButton_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)listBoxCourse.SelectedItem;
            pos = course.getAllCourse().Rows.Count-1;
            showData(pos);
        }
    }
}
