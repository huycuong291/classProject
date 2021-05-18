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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addStudentForm formAddStudent = new addStudentForm();
            formAddStudent.Show();
        }

        private void studentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listStuform formListStu = new listStuform();
            formListStu.loadStudentList();
            formListStu.Show();

        }

        private void staticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statics formStatics = new statics();
            formStatics.Show();

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printForm formPrint = new printForm();
            formPrint.loadStudentList();
            formPrint.Show();
        }

        private void removeCouresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeCform rev = new removeCform();
            rev.Show();
        }

        private void addNewCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCourseForm addCrsForm = new AddCourseForm();
            addCrsForm.Show();
        }

        private void manageStudentFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manageForm Managefrom = new manageForm();
            Managefrom.Show();
        }

        private void editCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editCForm newForm = new editCForm();

            newForm.Show();
        }

        private void mANAGECUORSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manageCourse newForm = new manageCourse();
            newForm.Show();
        }

        private void pRINTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            printCourseForm newf = new printCourseForm();
            newf.Show();
        }

        private void aDDSCOREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addScoreForm asf = new addScoreForm();
            asf.Show();
        }

        private void printToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void removeScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeScoreForm rsf = new removeScoreForm();
            rsf.Show();
        }

        private void manageScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
