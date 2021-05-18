using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace classProject
{
    class loginDB
    {
        public DataTable getUser(SqlCommand command)
        {
            command.Connection = mydb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        DB2 mydb = new DB2();
        //function to insert new student
        public bool insertUser(string name, string password)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Login (name, password)" +" VALUES (@n,@p)", mydb.GetConnection);
            command.Parameters.Add("@n", SqlDbType.VarChar).Value = name;
            command.Parameters.Add("@p", SqlDbType.VarChar).Value = password;
           
            mydb.openConnectionState();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
    }
}

