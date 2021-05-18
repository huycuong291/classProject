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
    public partial class removeCform : Form
    {
        public removeCform()
        {
            InitializeComponent();
        }

        private void remove_button_Click(object sender, EventArgs e)
        {
          
            {
                COURSE CRS = new COURSE();
                string id = CN_txt.Text;
                if (MessageBox.Show("Are you sure?", "delete student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    if (CRS.deleteCourse(id))
                    {

                        MessageBox.Show("Done", "delete student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CN_txt.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Error", "delete student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void CN_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_addCN_Click(object sender, EventArgs e)
        {

        }
    }
}
