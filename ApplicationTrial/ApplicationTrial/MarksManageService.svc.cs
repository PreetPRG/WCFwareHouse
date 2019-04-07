using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ApplicationTrial
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IMarksManageService
    {
        public string AddMarks(MarksRecords marks)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MarksManagementDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from MarksRecords where UserID = @uid1 and Semester = @sem1";
            cmd.Parameters.AddWithValue("@uid1", marks.UserID);
            cmd.Parameters.AddWithValue("@sem1", marks.Semester);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Close();
                con.Close();
                return null;
            }
            else
            {
                reader.Close();
                cmd.CommandText = "insert into MarksRecords(UserID,Semester,Subject1,Subject2,Subject3) values (@uid,@sem,@s1,@s2,@s3)";
                cmd.Parameters.AddWithValue("@uid", marks.UserID);
                cmd.Parameters.AddWithValue("@sem", marks.Semester);
                cmd.Parameters.AddWithValue("@s1", marks.Subject1);
                cmd.Parameters.AddWithValue("@s2", marks.Subject2);
                cmd.Parameters.AddWithValue("@s3", marks.Subject3);
                float per = (float)(marks.Subject1 + marks.Subject2 + marks.Subject3) / 3;
                string result = null;
                if (per < 35)
                {
                    result = "FAIL";
                }
                else
                {
                    result = "PASS";
                }
                cmd.ExecuteNonQuery();
                con.Close();
                return result;
            }
        }

        public string Login(string ID, string Password)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MarksManagementDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Users where UserID = @uid and Password = @pwd";
            cmd.Parameters.AddWithValue("@uid", ID);
            cmd.Parameters.AddWithValue("@pwd", Password);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                string name = reader.GetString(1);
                reader.Close();
                con.Close();
                return name;
            }
            else
            {
                reader.Close();
                con.Close();
                return null;
            }
        }

        public bool Register(UserDetails user)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MarksManagementDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Users where UserID = @uid";
            cmd.Parameters.AddWithValue("@uid", user.UserID);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Close();
                con.Close();
                return false;
            }
            else
            {

                reader.Close();
                cmd.CommandText = "insert into Users(UserID,UserName,Password) values (@uid1,@un1,@pwd1)";
                cmd.Parameters.AddWithValue("@uid1", user.UserID);
                cmd.Parameters.AddWithValue("@un1", user.UserName);
                cmd.Parameters.AddWithValue("@pwd1", user.Password);
                cmd.ExecuteNonQuery();

                con.Close();
                return true;
            }
        }

        public bool DeleteMarksRecordBySem(string ID, int sem)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MarksManagementDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from MarksRecords where UserID = @uid and Semester = @sem";
            cmd.Parameters.AddWithValue("@uid", ID);
            cmd.Parameters.AddWithValue("@sem", sem);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Close();
                cmd.CommandText = "delete from MarksRecords where UserID = @uid1 and Semester = @sem1";
                cmd.Parameters.AddWithValue("@uid1", ID);
                cmd.Parameters.AddWithValue("@sem1", sem);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            reader.Close();
            con.Close();
            return false;
        }

        public List<MarksRecords> SearchByID(string ID)
        {
            List<MarksRecords> MarksList = new List<MarksRecords>();

            int i, length;

            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MarksManagementDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from MarksRecords where UserID = @uid";
            cmd.Parameters.AddWithValue("@uid", ID);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            con.Open();

            da.Fill(ds, "MarksRecords");
            DataTable dt = ds.Tables["MarksRecords"];
            length = ds.Tables["MarksRecords"].Rows.Count;

            if (length == 0)
            {
                return null;
            }

            for (i = 0; i < length; i++)
            {
                MarksRecords m = new MarksRecords();
                m.UserID = ds.Tables["MarksRecords"].Rows[i][0].ToString();
                m.Semester = (int)ds.Tables["MarksRecords"].Rows[i][1];
                m.Subject1 = (int)ds.Tables["MarksRecords"].Rows[i][2];
                m.Subject2 = (int)ds.Tables["MarksRecords"].Rows[i][3];
                m.Subject3 = (int)ds.Tables["MarksRecords"].Rows[i][4];
                MarksList.Add(m);
            }

            return MarksList;
        }

        public string UpdateMarks(string ID, int sem, int subNo, int marks)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MarksManagementDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from MarksRecords where UserID = @uid and Semester = @sem";
            cmd.Parameters.AddWithValue("@uid", ID);
            cmd.Parameters.AddWithValue("@sem", sem);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                int total = 0;
                string sub;
                switch (subNo)
                {
                    case 1:
                        total = reader.GetInt32(2) + reader.GetInt32(3);
                        sub = "Subject1";
                        break;
                    case 2:
                        total = reader.GetInt32(1) + reader.GetInt32(3);
                        sub = "Subject2";
                        break;
                    case 3:
                        total = reader.GetInt32(1) + reader.GetInt32(2);
                        sub = "Subject3";
                        break;
                    default:
                        return null;
                }
                reader.Close();
                string cmdtxt = "update MarksRecords set " + sub + " = @mar where UserID = @uid1 and Semester = @sem1";
                cmd.CommandText = cmdtxt;
                cmd.Parameters.AddWithValue("@mar", marks);
                cmd.Parameters.AddWithValue("@uid1", ID);
                cmd.Parameters.AddWithValue("@sem1", sem);
                cmd.ExecuteNonQuery();
                con.Close();
                total += marks;
                float per = (float)total / 3;
                string result = null;
                if (per < 35.0)
                {
                    result = "FAIL";
                }
                else
                {
                    result = "PASS";
                }
                return result;

            }
            return null;
        }
    }
}
