using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace classProject
{
    class SCORE

    {
        DB mydb = new DB();
        public bool stuScoreExist(int studentID, int courseID)
        {
            SqlCommand command = new SqlCommand(" select * from score where student_id = @sid, course_id = @cid", mydb.GetConnection);

            command.Parameters.Add("@sid", SqlDbType.Int).Value = studentID;

            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseID;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count == 0)
            {
                return true;
            }
            else return false;
        }

        public bool insertScore(int studentId, int courseId, double score, string description)
        {
            SqlCommand command = new SqlCommand("INSERT INTO [dbo].[score] (studentid, courseid, score, description) VALUES (@sid,@cid,@scr,@dct)", mydb.GetConnection);

            command.Parameters.Add("@sid", SqlDbType.Int).Value = studentId;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseId;
            command.Parameters.Add("@scr", SqlDbType.Float).Value = score;
            command.Parameters.Add("@dct", SqlDbType.Text).Value = description;

            mydb.openConnectionState();
            if (command.ExecuteNonQuery() == 1)
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

        public DataTable getStudentsScore()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.GetConnection;
            command.CommandText = ("SELECT [dbo].[score].studentid, [dbo].[student11].fullname,  [dbo].[score].courseid, [dbo].[course].label, [dbo].[score].score FROM [dbo].[student11] INNER JOIN [dbo].[score] ON [dbo].[student11].id = [dbo].[score].studentid INNER JOIN [dbo].[course] ON [dbo].[score].courseid = [dbo].[course].id");

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool deleteScoure(int studentId, int courseId)
        {
            SqlCommand command = new SqlCommand("DELETE FROM [dbo].[score] WHERE studentid =@sid AND courseid=@cid", mydb.GetConnection);
            command.Parameters.Add("@sid", SqlDbType.Int).Value = studentId;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseId;
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

        public DataTable avgScoreByCourse()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.GetConnection;
            command.CommandText = ("SELECT [dbo].[course].label, avg([dbo].[score].score) as Average_Score FROM [dbo].[course], [dbo].[score] WHERE [dbo].[course].id=[dbo].[score].courseid GROUP BY [dbo].[course].label");

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getCourseScores(int courseId)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.GetConnection;
            command.CommandText = ("SELECT [dbo].[score].studentid, [dbo].[student11].fullname [dbo].[score].courseid, [dbo].[course].label, [dbo].[score].score FROM [dbo].[student11] INNER JOIN [dbo].[score] ON [dbo].[student11].id = [dbo].[score].studentid INNER JOIN [dbo].[course] ON [dbo].[score].courseid = [dbo].[course].id WHERE  [dbo].[score].courseid = " + courseId);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getStudentScores(int studentId)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.GetConnection;
            command.CommandText = ("SELECT [dbo].[score].studentid, [dbo].[student11].fullname, [dbo].[score].courseid, [dbo].[course].label, [dbo].[score].score FROM [dbo].[student11] INNER JOIN [dbo].[score] ON [dbo].[student11].id = [dbo].[score].studentid INNER JOIN [dbo].[course] ON [dbo].[score].courseid = [dbo].[course].id WHERE  [dbo].[score].studentid = " + studentId);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getALL_IdCourseOrder()
        {
            DB db = new DB();
            try
            {
                db.openConnectionState();
                SqlCommand command = new SqlCommand()
                {
                    Connection = db.GetConnection,
                    CommandText = "SELECT studentid, courseid, score " +
                                    "FROM myDB.[dbo].[score] " +
                                    "order by studentid, courseid"
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

        public DataTable getAvg_byStudent()
        {
            DB db = new DB();
            try
            {
                db.openConnectionState();
                SqlCommand command = new SqlCommand()
                {
                    Connection = db.GetConnection,
                    CommandText = "SELECT myDB.[dbo].[score].studentid, AVG(myDB.[dbo].[score].score) " +
                                    "FROM myDB.[dbo].[student11] inner join myDB.[dbo].[score] on myDB.[dbo].[student11].Id = myDB.[dbo].[score].studentid " +
                                    "Group by myDB.[dbo].[score].studentid " +
                                    "order by myDB.[dbo].[score].studentid "
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

        public DataTable MakeStudentScoreResultTable()
        {
            try
            {
                StuDB student = new StuDB();
                COURSE course = new COURSE();
                SCORE score = new SCORE();

                //create column

                DataTable result = student.getAllBriefInfo();
                result.Columns[0].ColumnName = "Id";
                result.Columns[1].ColumnName = "Full Name";


                DataTable coursesLabel = course.allLabel_IdOrder();
                DataTable briefInfo = student.getAllBriefInfo();
                DataTable scores = score.getALL_IdCourseOrder();
                DataTable avgScore = score.getAvg_byStudent();

                for (int i = 0; i < coursesLabel.Rows.Count; i++)
                {
                    result.Columns.Add(coursesLabel.Rows[i][1].ToString().Trim());
                }

                result.Columns.Add("Result");

                //fill score to table 
                int scoreRow = 0;
                for (int row = 0; row < result.Rows.Count; row++)
                {
                    int courseIndex = 0;
                    while (result.Rows[row][0].ToString().Trim() == scores.Rows[scoreRow][0].ToString().Trim())
                    {
                        result.Rows[row][courseIndex + 3] = scores.Rows[scoreRow][2].ToString().Trim();
                        courseIndex++;
                        scoreRow++;
                        if (scoreRow > scores.Rows.Count - 1)
                        {
                            break;
                        }
                    }
                }
                for (int row = 0; row < result.Rows.Count; row++)
                {
                    result.Rows[row][result.Columns.Count - 1] = avgScore.Rows[row][1].ToString().Trim();
                }

                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable getScore(SqlCommand command)
        {
            command.Connection = mydb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

    }
}
