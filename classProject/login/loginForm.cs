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

namespace classProject
{
    public partial class loginForm : Form
    {
        public bool isSignup { get; set; }
        public bool isLogin { get; set; }
        public loginForm()
        {
            InitializeComponent();
            isLogin = false;
            isSignup = false;
        }

        private void showPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '•')
            {
                hidePassword.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }

        private void hidePassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                showPassword.BringToFront();
                txtPassword.PasswordChar = '•';
            }
        }

        private void button_LogIn_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\huycu\Desktop\classProject\DB\login.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                string query = "Select * from Login Where name = '" + txtUsername.Text.Trim() + "'and password = '" + txtPassword.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count >0 )
                {
                    
                    isLogin = true;
                    this.Close();

                }
                else MessageBox.Show("wrong user name or password!");
            }
        }

     
        private void signUp_Click(object sender, EventArgs e)
        {
            isSignup = true;
            this.Close();
        }
    }
}
