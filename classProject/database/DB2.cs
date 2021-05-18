using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace classProject
{
    class DB2
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\huycu\Desktop\classProject\DB\login.mdf;Integrated Security=True;Connect Timeout=30");
        public SqlConnection GetConnection
        {
            get
            {
                return con;
            }
        }

        public void openConnectionState()
        {
            if ((con.State == ConnectionState.Closed))
            {
                con.Open();
            }
        }

        public void closeConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }


}