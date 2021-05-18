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
    public partial class statics : Form
    {
        public statics()
        {
            InitializeComponent();
        }
        Color panTotalColor;
        Color panMaleColor;
        Color panFemaleColor;
        private void statics_Load(object sender, EventArgs e)
        {
            DB mydb = new DB();
            panTotalColor = PanelTotal.BackColor;
            panMaleColor = PanelMale.BackColor;
            panFemaleColor = PanelFemale.BackColor;

           

            StuDB student = new StuDB();
            mydb.openConnectionState();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from student11 ", mydb.GetConnection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            double total = Convert.ToDouble(table.Rows.Count);
            
           
            SqlDataAdapter adapter1 = new SqlDataAdapter("Select * from student11 where gender ='Male      '", mydb.GetConnection);
            DataTable table1 = new DataTable();
            adapter1.Fill(table1);
            double totalMale = Convert.ToDouble(table1.Rows.Count);
      

            SqlDataAdapter adapter2 = new SqlDataAdapter("Select * from student11 where gender ='Female    '", mydb.GetConnection);
            DataTable table2 = new DataTable();
            adapter2.Fill(table2);
            double totalFemale = Convert.ToDouble(table2.Rows.Count);
            mydb.closeConnection();

           
            double maleStudentsPercentage = (totalMale * (100 / total));
            double femaleStudentsPercentage = (totalFemale * (100 / total));
            LabelTotal.Text = ("Total Students: " + total.ToString());
            maleLable.Text = ("Male : " + (maleStudentsPercentage.ToString("0.00") + "%"));
            Female.Text = ("Female : " + (femaleStudentsPercentage.ToString("0.00") + "%"));

            if (femaleStudentsPercentage == 0)
            {
                chart2.Series["s1"].Points.AddXY("Male", "" + maleStudentsPercentage);

            }
            else if (maleStudentsPercentage == 0)
            {
                chart2.Series["s1"].Points.AddXY(" ", "" + maleStudentsPercentage);
                chart2.Series["s1"].Points.AddXY("Female", "" + femaleStudentsPercentage);
            }
            else 
            {
                chart2.Series["s1"].Points.AddXY("Male", "" + maleStudentsPercentage);
                chart2.Series["s1"].Points.AddXY("Female", "" + femaleStudentsPercentage);

            }
            

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }
    }

}
