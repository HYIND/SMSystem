using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;

namespace SMSystem
{
    class StuCourse
    {
        public string Cno { get; set; }
        public string Cname { get; set; }
        public string Cpno { get; set; }
        public int grade { get; set; }
        public int Ccredit { get; set; }

        public static List<StuCourse> ShowMyCourse()
        {
            List<StuCourse> list = new List<StuCourse>();
            string sql = "select cno,cname,cpno,grade,ccredit from StuSCInfo where sno=" + StuUI.mStuUI.user.Sno;
            OracleConnection con = new OracleConnection(Program.strCon);
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(sql, con);
                OracleDataReader odr = cmd.ExecuteReader();
                while (odr.Read())
                {
                    StuCourse c = new StuCourse();
                    c.Cno = odr.GetString(0);
                    c.Cname = odr.GetString(1);
                    if (odr.IsDBNull(2)) c.Cpno = null;
                    else c.Cpno = odr.GetString(2);
                    if (odr.IsDBNull(3)) c.grade = 0;
                    else c.grade = odr.GetInt16(3);
                    c.Ccredit = odr.GetInt16(4);
                    list.Add(c);
                }
            }
            finally
            {
                con.Close();
            }
            return list;
        }

        public static List<StuCourse> SelectMyCourse(string a,int i)
        {
            List<StuCourse> list = new List<StuCourse>();
            string sql = null;
            if(i==1){ sql= "select cno,cname,cpno,grade,ccredit from StuSCInfo where sno =" 
                    + StuUI.mStuUI.user.Sno+"and cname like :a";}
            else sql = "select cno,cname,cpno,grade,ccredit from StuSCInfo where sno="
                + StuUI.mStuUI.user.Sno+"and cno like :a";
            OracleParameter[] para = new OracleParameter[]
            {
                new OracleParameter(":a",OracleDbType.Varchar2,10)
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
                    StuCourse c = new StuCourse();
                    c.Cno = odr.GetString(0);
                    c.Cname = odr.GetString(1);
                    if (odr.IsDBNull(2)) c.Cpno = null;
                    else c.Cpno = odr.GetString(2);
                    c.grade = odr.GetInt16(3);
                    c.Ccredit = odr.GetInt16(4);
                    list.Add(c);
                }
            }
            finally
            {
                con.Close();
            }
            return list;
        }

        public static int DropCourse(string cno)
            {
            int result = 0;
            string sql = "delete from sc where cno=:cno and sno="+StuUI.mStuUI.user.Sno;
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

        public static int TakeCourse(string cno)
        {
            int result = 0;
            string sql1 = "select*from sc where cno=" + cno+"and sno="+StuUI.mStuUI.user.Sno;
            OracleConnection con = new OracleConnection(Program.strCon);
            try
            {
                con.Open();
                OracleCommand cmd1 = new OracleCommand(sql1, con);
                OracleDataReader odr = cmd1.ExecuteReader();
                if (odr.HasRows)
                {
                    MessageBox.Show("此课程已在我的选课中！");
                    return result;
                }
                else 
                {
                    string sql2 = "Insert into SC(sno,cno)values(" + StuUI.mStuUI.user.Sno + "," + cno + ")";
                    OracleCommand cmd2 = new OracleCommand(sql2, con);
                    result = cmd2.ExecuteNonQuery();
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
            return result;
        }
    }
}
