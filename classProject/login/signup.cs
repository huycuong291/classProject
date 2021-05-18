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
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

     

      
        private void su_ok_Click(object sender, EventArgs e)
        {
            loginDB newUser = new loginDB();
            string U_name = su_name.Text;
            string U_pass = su_pass.Text;
         if (Verify())
            {
               
                if (newUser.insertUser(U_name,U_pass))
                {
                    MessageBox.Show("New user added successfully!", "Add student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Error!", "Add user", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty fields", "Add user", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        bool Verify()
        {
            if ((su_name.Text.Trim() == "") || (su_pass.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void showPassword_Click_1(object sender, EventArgs e)
        {
            if (su_pass.PasswordChar == '•')
            {
                hidePassword.BringToFront();
                su_pass.PasswordChar = '\0';
            }
        }

        private void hidePassword_Click_1(object sender, EventArgs e)
        {
                if (su_pass.PasswordChar == '\0')
                {
                    showPassword.BringToFront();
                    su_pass.PasswordChar = '•';
                }
        }

        private void su_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

