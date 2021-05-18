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
    class StuDB
    {
        public DataTable getStudents(SqlCommand command)
        {
            command.Connection = mydb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        DB mydb = new DB();
        //function to insert new student
        public bool insertStudent(int Id, string fullname, DateTime bdate, string gender, string phone, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO student11 (id, fullname, dob, gender, phone, address, picture)" +
                " VALUES (@id,@fn,@dob,@gdr,@phn,@adrs,@pic)", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fullname;
            command.Parameters.Add("@dob", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

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
        public bool updateStudent(int Id, string fullname, DateTime bdate, string gender, string phone, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("Update student11 SET fullname=@fn,dob=@dob,gender=@gdr,phone=@phn,address=@adrs,picture=@pic Where id=@id ", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fullname;
            command.Parameters.Add("@dob", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

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
   
        public bool deleteStudent(int Id)
        {
            SqlCommand command = new SqlCommand("DELETE from student11 Where id=@id ", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
           
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
        public DataTable getAllBriefInfo()
        {
            DB db = new DB();
            try
            {
                db.openConnectionState();
                SqlCommand command = new SqlCommand()
                {
                    Connection = db.GetConnection,
                    CommandText = "SELECT id, fullname FROM myDB.[dbo].[student11]"
                };
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                DataTable table = new DataTable();
                adapter.Fill(table);
                db.closeConnection();

                return table;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.closeConnection();
            }

        }
    }
}
