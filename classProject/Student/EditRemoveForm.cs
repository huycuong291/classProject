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

namespace classProject
{
    public partial class EditRemoveForm : Form
    {
        public EditRemoveForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            String pictureLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png|All files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    pictureLocation = dialog.FileName;
                    ER_picture.ImageLocation = pictureLocation;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void uploadPic_Click(object sender, EventArgs e)
        {
            String pictureLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png|All files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    pictureLocation = dialog.FileName;
                    ER_picture.ImageLocation = pictureLocation;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {

            StuDB student = new StuDB();
            int id = Convert.ToInt32(ER_id_txt.Text);
            string fname =ER_name_txt.Text;
            DateTime dob = ER_dob1.Value;
            string phone = ER_phone_txt.Text;
            string address = ER_address_txt.Text;
            string gender = "Other";

            if (ER_male.Checked)
            {
                gender = "Male";
            }

            if (ER_female.Checked)
            {
                gender = "Female";
            }

            MemoryStream pic = new MemoryStream();

            int born_year = ER_dob1.Value.Year;
            int this_year = DateTime.Now.Year;
            if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
            {
                MessageBox.Show("The student's age must be between 10 and 100 years old", "Invalid Date of birth", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (Verify())
            {
                ER_picture.Image.Save(pic, ER_picture.Image.RawFormat);
                if (student.updateStudent(id, fname, dob, gender, phone, address, pic))
                {
                    MessageBox.Show("Student update successfully!", "Add student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    MessageBox.Show("Error!", "update student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty fields", "edit student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        bool Verify()
        {
            if ((ER_name_txt.Text.Trim() == "") || (ER_address_txt.Text.Trim() == "") || (ER_phone_txt.Text.Trim() == "") || (ER_picture.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void remove_Click(object sender, EventArgs e)
        {
            StuDB student = new StuDB();
            int id = Convert.ToInt32(ER_id_txt.Text);
            if(MessageBox.Show("Are you sure?","delete student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (student.deleteStudent(id))
                {

                    MessageBox.Show("Done", "delete student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ER_address_txt.Text = "";
                    ER_dob1.Value = DateTime.Now;
                    ER_id_txt.Text = "";
                    ER_name_txt.Text = "";
                    ER_phone_txt.Text = "";
                    ER_picture = null; 
                }
                else
                {
                    MessageBox.Show("Error", "delete student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
