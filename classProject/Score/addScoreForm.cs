using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace classProject
{
    public partial class addScoreForm : Form
    {
        public addScoreForm()
        {
            InitializeComponent();
        }

        SCORE score = new SCORE();
        COURSE course = new COURSE();
        StuDB student = new StuDB();

        private void addScoreForm_Load_1(object sender, EventArgs e)
        {
            comboBoxCourse.DataSource = course.getAllCourse();
            comboBoxCourse.DisplayMember = "label";
            comboBoxCourse.ValueMember = "id";

            SqlCommand command = new SqlCommand("SELECT id, fullname FROM [dbo].[student11]");
            score_dgv.DataSource = student.getStudents(command);
            score_dgv.Columns[0].Width = 30;
            score_dgv.Columns[1].Width = 135;
          
        }
        private void score_dgv_Click(object sender, EventArgs e)
        {
            textBoxStudentID.Text = score_dgv.CurrentRow.Cells[0].Value.ToString();
        }

        private void buttonAddScore_Click_1(object sender, EventArgs e)
        {
            try
            {
                int studentId = Convert.ToInt32(textBoxStudentID.Text);
                int courseId = Convert.ToInt32(comboBoxCourse.SelectedValue);
                double scorevalue = Convert.ToDouble(textBoxScore.Text);
                string description = textBoxDescription.Text;

                if (score.insertScore(studentId, courseId, scorevalue, description))
                {
                    MessageBox.Show("Student Score Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Student Score Not Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
