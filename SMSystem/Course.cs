using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;

namespace SMSystem
{
    public class Course
    {
        public string Cno { get; set; }
        public string Cname { get; set; }
        public string Cpno { get; set; }
        public int Ccredit { get; set; }
        public static List<Course> SelectCourse(string a,int i)
        {
            List<Course> list = new List<Course>();
            string sql=null;
            if (i == 1)
            {
                sql = "select cno,cname,cpno,ccredit from course where cname like :a";
            }
            else sql = "select cno,cname,cpno,ccredit from course where cno like :a";
            OracleParameter[] para = new OracleParameter[]
            {
                new OracleParameter(";a",OracleDbType.Varchar2,10)
            };
            para[0].Value = a + "%";
            OracleConnection con = new OracleConnection(Program.strCon);
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(sql, con);
                cmd.Parameters.AddRange(para);
                OracleDataReader odr = cmd.ExecuteReader();
                while (odr.Read())
                {
                    Course c = new Course();
                    c.Cno = odr.GetString(0);
                    c.Cname = odr.GetString(1);
                    if (odr.IsDBNull(2)) c.Cpno = null;
                    else c.Cpno = odr.GetString(2);
                    c.Ccredit = odr.GetInt16(3);
                    list.Add(c);
                }
            }
            finally
            {
                con.Close();
            }
            return list;
        }

        public static int DeleteCourse(string cno)
        {
            int result = 0;
            string sql = "delete from course where cno=:cno";
            OracleParameter[] para = new OracleParameter[]
            {
                new OracleParameter(";cno",OracleDbType.Varchar2,4)
            };
            para[0].Value = cno;
            OracleConnection con = new OracleConnection(Program.strCon);
            try 
            { 
                con.Open();
                OracleCommand cmd = new OracleCommand(sql, con);
                cmd.Parameters.AddRange(para);
                result = cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        public static int UpdateCourse(Course c)
        {
            int result = 0;
            string sql = "update course set Cname=:cname,Cpno=:cpno,Ccredit=:ccredit where Cno=:cno";
            OracleParameter[] para = new OracleParameter[]
            {
                new OracleParameter(":cname", OracleDbType.Varchar2, 40),
                new OracleParameter(":cpno", OracleDbType.Varchar2, 4),
                new OracleParameter(":ccredit", OracleDbType.Int32),
                new OracleParameter(":cno", OracleDbType.Varchar2, 4)
            };
            para[0].Value = c.Cname;
            if (string.IsNullOrEmpty(c.Cpno))
                para[1].Value = DBNull.Value;
            else para[1].Value = c.Cpno;
            para[2].Value = c.Ccredit;
            para[3].Value = c.Cno;
            OracleConnection con = new OracleConnection(Program.strCon);
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(sql, con);
                cmd.Parameters.AddRange(para);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        public static int AddCourse(Course c)
        {
            int result = 0;
            string sql = "Insert into course values(:cno,:cname,:cpno,:ccredit) ";
            OracleParameter[] para = new OracleParameter[]
            {
                new OracleParameter(":cname", OracleDbType.Varchar2, 40),
                new OracleParameter(":cpno", OracleDbType.Varchar2, 4),
                new OracleParameter(":ccredit", OracleDbType.Int32),
                new OracleParameter(":cno", OracleDbType.Varchar2, 4)
            };
            para[0].Value = c.Cname;
            if (string.IsNullOrEmpty(c.Cpno))
                para[1].Value = DBNull.Value;
            else para[1].Value = c.Cpno;
            para[2].Value = c.Ccredit;
            para[3].Value = c.Cno;
            OracleConnection con = new OracleConnection(Program.strCon);
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(sql, con);
                cmd.Parameters.AddRange(para);
                result = cmd.ExecuteNonQuery();
            }
                catch(Exception ex)
                {
                MessageBox.Show(ex.Message);
                }
            finally
            {
                con.Close();
            }
            return result;
        }

    }
}