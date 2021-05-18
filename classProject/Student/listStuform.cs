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
    public partial class listStuform : Form
    {
        public listStuform()
        {
            InitializeComponent();

        }
        DB mydb = new DB();
        public void loadStudentList()
        {
            mydb.openConnectionState();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from student11 ", mydb.GetConnection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            listStu.DataSource = table;
            listStu.RowTemplate.Height = 80;
            //DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            //picCol = (DataGridViewImageColumn)dataGridViewStudentList.Columns[7];
            //picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            listStu.AutoGenerateColumns = false;
            mydb.closeConnection();
        }

   

      

      

     

        private void button1_Click(object sender, EventArgs e)
        {
            loadStudentList();
        }

        private void listStuform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'student11DataSet1.student11' table. You can move, or remove it, as needed.
            this.student11TableAdapter1.Fill(this.student11DataSet1.student11);
            // TODO: This line of code loads data into the 'student11DataSet.student11' table. You can move, or remove it, as needed.
            this.student11TableAdapter.Fill(this.student11DataSet.student11);
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            EditRemoveForm newForm = new EditRemoveForm();
            newForm.ER_id_txt.Text = listStu.CurrentRow.Cells[0].Value.ToString();
            newForm.ER_name_txt.Text = listStu.CurrentRow.Cells[1].Value.ToString();
            newForm.ER_dob1.Value = (DateTime)listStu.CurrentRow.Cells[2].Value;
            if (listStu.CurrentRow.Cells[3].Value.ToString() != "Male      ")
            {
                newForm.ER_female.Checked = true;
            }
          
            newForm.ER_phone_txt.Text = listStu.CurrentRow.Cells[4].Value.ToString();
            newForm.ER_address_txt.Text = listStu.CurrentRow.Cells[5].Value.ToString();
            byte[] pic;
            pic = (byte[])listStu.CurrentRow.Cells[6].Value;
            MemoryStream picture = new MemoryStream(pic);
            newForm.ER_picture.Image = Image.FromStream(picture);
            newForm.Show();
        }

        private void listStu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //private void StudentListForm_Load(object sender, EventArgs e)
        //{
        //    // TODO: This line of code loads data into the '_D__GIANG_WINDOWS_PROGRAMMING_STUDENT_MANAGEMENT_SYSTEM_MYDB_STUDENT_MANAGEMENT__SYSTEM_MDFDataSet.Student' table. You can move, or remove it, as needed.
        //    this.studentTableAdapter.Fill(this._D__GIANG_WINDOWS_PROGRAMMING_STUDENT_MANAGEMENT_SYSTEM_MYDB_STUDENT_MANAGEMENT__SYSTEM_MDFDataSet.Student);

        //}
    }
}

