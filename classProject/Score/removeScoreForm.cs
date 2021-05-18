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
    public partial class removeScoreForm : Form
    {
        public removeScoreForm()
        {
            InitializeComponent();
        }
        SCORE score = new SCORE();
        private void removeScoreForm_Load_1(object sender, EventArgs e)
        {
            removeScore_dgv.DataSource = score.getStudentsScore();
        }

        private void buttonRemoveScore_Click_1(object sender, EventArgs e)
        {
            int studentId = int.Parse(removeScore_dgv.CurrentRow.Cells[0].Value.ToString());
            int courseId = int.Parse(removeScore_dgv.CurrentRow.Cells[2].Value.ToString());

            try
            {

                if ((MessageBox.Show("Are you sure you want to delete this score", "Delete Score", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (score.deleteScoure(studentId, courseId))
                    {
                        MessageBox.Show("Score deleted", " Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        removeScore_dgv.DataSource = score.getStudentsScore();
                    }
                    else
                    {
                        MessageBox.Show("Score not deleted", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please enter valid id", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
