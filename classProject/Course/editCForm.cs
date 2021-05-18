using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Reflection.Metadata;

using System.Drawing.Imaging;
using iTextSharp.text.pdf;
using iTextSharp.text;
namespace classProject
{
    public partial class editCForm : Form
    {
        public editCForm()
        {
            InitializeComponent();
        }
        DB mydb = new DB();

        private void editForm_Load(object sender, EventArgs e)
        {

        }

        private void find_button_Click(object sender, EventArgs e)
        {

            mydb.openConnectionState();
            SqlDataAdapter adapter = new SqlDataAdapter();
            string value = courseLabel_txt.Text;


        }



        COURSE course = new COURSE();


        private void comboBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
          try
            {
                int id = Convert.ToInt32(comboBoxCourse.SelectedValue);
                DataTable table = new DataTable();
                table = course.getCourseByID(id);

                courseLabel_txt.Text = table.Rows[0][1].ToString();

                numericUpDownHours.Value = Int32.Parse(table.Rows[0][2].ToString());

                description_txt.Text = table.Rows[0][3].ToString();
            }
            catch {  }
        }

        private void editCForm_Load(object sender, EventArgs e)
        {
            comboBoxCourse.DataSource = course.getAllCourse();
            comboBoxCourse.DisplayMember = "label";
            comboBoxCourse.ValueMember = "id";

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string name = courseLabel_txt.Text;
            int hour =(int)numericUpDownHours.Value;
            string desc = description_txt.Text;
            int id = (int)comboBoxCourse.SelectedValue;
            COURSE course = new COURSE();
            if (courseLabel_txt.Text.Trim() == "")
            {
                MessageBox.Show("error!!! Course name is null!!");
            }
            else
            {
                if (course.updateCourse(id, name, hour, desc))
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

