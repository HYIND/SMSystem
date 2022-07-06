using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;

namespace SMSystem
{
    public class Student
    {
        public string Sno { get; set; }
        public string Sname { get; set; }
        public string Ssex { get; set; }
        public int Sage { get; set; }
        public string Sdept { get; set; }
        public string password { get; set; }
        public static List<Student> SelectStudent(string a, int i)
        {
            List<Student> list = new List<Student>();
            string sql = null;
            if (i == 1)
            {
                sql = "select sno,sname,ssex,sage,sdept,password from Student where sname like :a";
            }
            else sql = "select sno,sname,ssex,sage,sdept,password from Student where sno like :a";
            //:cnmae是查询参数
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
                    Student c = new Student();
                    c.Sno = odr.GetString(0);
                    c.Sname = odr.GetString(1);
                    c.Ssex = odr.GetString(2);
                    c.Sage = odr.GetInt16(3);
                    c.Sdept = odr.GetString(4);
                    c.password = odr.GetString(5);
                    list.Add(c);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return list;
        }

        public static int DeleteStudent(string sno)
        {
            int result = 0;
            string sql = "delete from student where sno=:sno";
            OracleParameter[] para = new OracleParameter[]
            {
                new OracleParameter(";sno",OracleDbType.Varchar2,9)
            };
            para[0].Value = sno;
            OracleConnection con = new OracleConnection(Program.strCon);
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(sql, con);
                cmd.Parameters.AddRange(para);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally
            {
                con.Close();
            }
            return result;
        }

        public static int UpdateStudent(Student c)
        {
            int result = 0;
            string sql = "update Student set Sname=:sname,Ssex=:ssex,Sage=:sage,Sdept=:sdept,password=:password where Sno=:sno";
            OracleParameter[] para = new OracleParameter[]
            {
                new OracleParameter(":sname", OracleDbType.Varchar2, 20),
                new OracleParameter(":ssex", OracleDbType.Varchar2, 3),
                new OracleParameter(":sage", OracleDbType.Int32),
                new OracleParameter(":sdept", OracleDbType.Varchar2, 20),
                new OracleParameter(":password",OracleDbType.Varchar2,16),
                new OracleParameter(":sno",OracleDbType.Varchar2,9)
            };
            if (string.IsNullOrEmpty(c.Sname))
                para[0].Value = DBNull.Value;
            else para[0].Value = c.Sname;
            if (string.IsNullOrEmpty(c.Ssex))
                para[1].Value = DBNull.Value;
            else para[1].Value = c.Ssex;
            if (c.Sage == 0)
                para[2].Value = DBNull.Value;
            else para[2].Value = c.Sage;
            if (string.IsNullOrEmpty(c.Sdept))
                para[3].Value = DBNull.Value;
            else para[3].Value = c.Sdept;
            if (string.IsNullOrEmpty(c.password))
                para[4].Value = c.password;
            else para[4].Value = "123456";
            para[5].Value = c.Sno;
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

        public static int AddStudent(Student c)
        {
            int result = 0;
            string sql = "Insert into student values(:sno,:sname,:ssex,:sage,:sdept,:password) ";
            OracleParameter[] para = new OracleParameter[]
             {
                new OracleParameter(":sno",OracleDbType.Varchar2,9),
                new OracleParameter(":sname", OracleDbType.Varchar2, 20),
                new OracleParameter(":ssex", OracleDbType.Varchar2, 3),
                new OracleParameter(":sage", OracleDbType.Int32),
                new OracleParameter(":sdept", OracleDbType.Varchar2, 20),
                new OracleParameter(":password",OracleDbType.Varchar2,16)
             };
            para[0].Value = c.Sno;
            if (string.IsNullOrEmpty(c.Sname))
                para[1].Value = DBNull.Value;
            else para[1].Value = c.Sname;
            if (string.IsNullOrEmpty(c.Ssex))
                para[2].Value = DBNull.Value;
            else para[2].Value = c.Ssex;
            if (c.Sage == 0)
                para[3].Value = DBNull.Value;
            else para[3].Value = c.Sage;
            if (string.IsNullOrEmpty(c.Sdept))
                para[4].Value = DBNull.Value;
            else para[4].Value = c.Sdept;
            if (string.IsNullOrEmpty(c.password))
                para[5].Value = "123456";
            else para[5].Value = c.password;
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

        public static int UpdateMyInfo(Student c, string username)
        {
            int result = 0;
            string sql = "update Student set Sname=:sname,Ssex=:ssex,Sage=:sage,Sdept=:sdept where Sno=" + username;
            OracleParameter[] para = new OracleParameter[]
            {
                new OracleParameter(":sname", OracleDbType.Varchar2, 20),
                new OracleParameter(":ssex", OracleDbType.Varchar2, 3),
                new OracleParameter(":sage", OracleDbType.Int32),
                new OracleParameter(":sdept", OracleDbType.Varchar2, 20),
            };
            if (string.IsNullOrEmpty(c.Sname))
                para[0].Value = DBNull.Value;
            else para[0].Value = c.Sname;
            if (string.IsNullOrEmpty(c.Ssex))
                para[1].Value = DBNull.Value;
            else para[1].Value = c.Ssex;
            if (c.Sage == 0)
                para[2].Value = DBNull.Value;
            else para[2].Value = c.Sage;
            if (string.IsNullOrEmpty(c.Sdept))
                para[3].Value = DBNull.Value;
            else para[3].Value = c.Sdept;
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

        public static int UpdataMypassword(string password1, string password2, string username)
        {
            string sql1 = "select*from student where password=" + password1 + " and sno=" + username;
            OracleConnection con = new OracleConnection(Program.strCon);
            con.Open();
            OracleCommand cmd1 = new OracleCommand(sql1, con);
            OracleDataReader odr = cmd1.ExecuteReader();
            if (odr.HasRows)
            {
                int result = 0;
                string sql2 = "update Student set password=:password2 where Sno=" + username;
                OracleParameter[] para = new OracleParameter[]
                {
                new OracleParameter(":password", OracleDbType.Varchar2, 16),
                };
                if (string.IsNullOrEmpty(password2))
                    para[0].Value = "123456";
                else para[0].Value = password2;
                try
                {
                    OracleCommand cmd = new OracleCommand(sql2, con);
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
            else { MessageBox.Show("原密码错误！"); return 0; }
        }
    }
}
