using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
        
          // loginForm formLogin = new loginForm();
          // Application.Run(formLogin);
         //  if (formLogin.isLogin == true)
            {
                Application.Run( new mainForm());
            }
          //  else if(formLogin.isSignup== true)
        //    { Application.Run(new signup()); }

        }
    }
}
