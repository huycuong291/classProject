using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace classProject
{
    public partial class manageForm : Form
    {
        public manageForm()
        {
            InitializeComponent();
        }

        private void manageForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'student11DataSet.student11' table. You can move, or remove it, as needed.
            this.student11TableAdapter.Fill(this.student11DataSet.student11);

        }

        private void listStu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AF_id_txt.Text= listStu.CurrentRow.Cells[0].Value.ToString();
            AF_fullname_txt.Text = listStu.CurrentRow.Cells[1].Value.ToString();
            AF_dob_txt.Value = (DateTime)listStu.CurrentRow.Cells[2].Value;
            if (listStu.CurrentRow.Cells[3].Value.ToString() != "Male      ")
            {
               AF_female_check.Checked = true;
            }

            AF_phone_txt.Text = listStu.CurrentRow.Cells[4].Value.ToString();
            AF_address_txt.Text = listStu.CurrentRow.Cells[5].Value.ToString();
            byte[] pic;
            pic = (byte[])listStu.CurrentRow.Cells[6].Value;
            MemoryStream picture = new MemoryStream(pic);
            AF_picture_pic.Image = Image.FromStream(picture);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
           
                AF_id_txt.Text = "";
                AF_fullname_txt.Text = "";
                AF_phone_txt.Text = "";
                AF_address_txt.Text = "";
                AF_picture_pic.Image = null;
                AF_dob_txt.Text = "";
                listStu.DataSource = null;
            }

        private void button1_Click(object sender, EventArgs e)
        {
            
         
                string name = search_txt.Text;
                if (search_txt.Text.Trim() == "")
                {
                    MessageBox.Show("Error", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DB dataBase = new DB();
                    SqlCommand command = new SqlCommand(
                        "SELECT id, fullname, dob, gender, phone, address, picture FROM student11 WHERE address = @address or fullname = @address", dataBase.GetConnection);
                    command.Parameters.Add("@address", SqlDbType.NVarChar).Value = search_txt.Text;

                    dataBase.openConnectionState();
                    StuDB student = new StuDB();
                    DataTable table = student.getStudents(command);
                    if (table.Rows.Count > 0)
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = command;
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet, "std");
                        dataBase.closeConnection();
                       listStu.RowTemplate.Height = 50;
                        DataTable table1 = dataSet.Tables["std"];
                        listStu.DataSource = table1;
                        listStu.ReadOnly = true;
                        DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                        imageColumn = (DataGridViewImageColumn)listStu.Columns[6];
                        imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
                        listStu.AllowUserToAddRows = false;
                    }
                    else
                    {
                        MessageBox.Show("not found", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

            }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "delete student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                StuDB student = new StuDB();
                int id = Convert.ToInt32(AF_id_txt.Text);
                if (MessageBox.Show("Are you sure?", "delete student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    if (student.deleteStudent(id))
                    {

                        MessageBox.Show("Done", "delete student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AF_address_txt.Text = "";
                        AF_dob_txt.Value = DateTime.Now;
                        AF_id_txt.Text = "";
                        AF_fullname_txt.Text = "";
                        AF_phone_txt.Text = "";
                        AF_picture_pic = null;

                    }
                    else
                    {
                        MessageBox.Show("Error", "delete student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
    }

