using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace classProject
{
    class COURSE
    {
        DB mydb = new DB();
        public bool insertCourse(int id,string courseName, int hoursNumbers, string description)
        {
            SqlCommand command = new SqlCommand("INSERT INTO course (id,label, hours_number, description)" +
                " VALUES (@id,@name,@hrs,@desc)", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = courseName;
            command.Parameters.Add("@hrs", SqlDbType.Int).Value = hoursNumbers;
            command.Parameters.Add("@desc", SqlDbType.VarChar).Value = description;
            mydb.openConnectionState();
            if (command.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else return false; 
        }


        public bool updateCourse(string courseName, int hoursNumbers, string description)
        {
            SqlCommand command = new SqlCommand("Update course SET hours_number=@hrs,description=@desc    Where label=@name ", mydb.GetConnection);
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = courseName;
            command.Parameters.Add("@hrs", SqlDbType.Int).Value = hoursNumbers;
            command.Parameters.Add("@desc", SqlDbType.VarChar).Value = description;

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

        public bool deleteCourse(string courseName)
        {
            SqlCommand command = new SqlCommand("DELETE from course Where label=@cn ", mydb.GetConnection);
            command.Parameters.Add("@cn", SqlDbType.VarChar).Value = courseName;
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

        public DataTable getAllCourse()
        {
            SqlCommand command = new SqlCommand("select * from course ", mydb.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getCourseByID(int courseID)
        {
            SqlCommand command = new SqlCommand("select * from course where id=@cid ", mydb.GetConnection);
            command.Parameters.Add("@cid", SqlDbType.VarChar).Value = courseID;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public int totalCourse()
        {
            SqlCommand command = new SqlCommand("select * from course ", mydb.GetConnection);
                  SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            int a;
            a = table.Rows.Count;
            return a;
        }
        public bool updateCourse(int courseID, string courseName, int hour, string desc)
        {
            SqlCommand command = new SqlCommand("Update course set label=@cName , hours_number=@cH, description=@desc where id=@id ", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = courseID;
            command.Parameters.Add("@cName", SqlDbType.VarChar).Value = courseName;
            command.Parameters.Add("@cH", SqlDbType.Int).Value = hour;
            command.Parameters.Add("@desc", SqlDbType.VarChar).Value = desc;
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
        public DataTable allLabel_IdOrder()
        {
            DB db = new DB();
            try
            {
                db.openConnectionState();
                SqlCommand command = new SqlCommand()
                {
                    Connection = db.GetConnection,
                    CommandText = "select myDB.[dbo].[course].id, myDB.[dbo].[course].label " +
                                    "from myDB.[dbo].[course] " +
                                    "order by myDB.[dbo].[course].id"
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
