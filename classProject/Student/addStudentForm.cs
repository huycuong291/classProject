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
namespace classProject
{
    public partial class addStudentForm : Form
    {
        public addStudentForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            String pictureLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "All files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    pictureLocation = dialog.FileName;
                    AF_picture_pic.ImageLocation = pictureLocation;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        bool Verify()
        {
            if    ((AF_fullname_txt.Text.Trim() == "")|| (AF_address_txt.Text.Trim() == "")||(AF_phone_txt.Text.Trim() == "")|| (AF_picture_pic.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            StuDB student = new StuDB();
            int id = Convert.ToInt32(AF_id_txt.Text);
            string fname = AF_fullname_txt.Text;
            DateTime dob = AF_dob_txt.Value;
            string phone = AF_phone_txt.Text;
            string address = AF_address_txt.Text;
            string gender = "Other";

            if (AF_male_check.Checked)
            {
                gender = "Male";
            }

            if (AF_female_check.Checked)
            {
                gender = "Female";
            }

            MemoryStream pic = new MemoryStream();
            int born_year = AF_dob_txt.Value.Year;
            int this_year = DateTime.Now.Year;
            if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
            {
                MessageBox.Show("The student's age must be between 10 and 100 years old", "Invalid Date of birth", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (Verify())
            {
                AF_picture_pic.Image.Save(pic, AF_picture_pic.Image.RawFormat);
                if (student.insertStudent(id, fname, dob, gender, phone, address, pic))
                {
                    MessageBox.Show("New student added successfully!", "Add student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error!", "Add student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty fields", "Add student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void addStudentForm_Load(object sender, EventArgs e)
        {

        }
    }
}


