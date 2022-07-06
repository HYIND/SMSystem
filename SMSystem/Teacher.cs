using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;

namespace SMSystem
{
    class Teacher
    {
        public string tno { get; set; }
        public string tname { get; set; }
        public string tsex { get; set; }
        public int tsalary { get; set; }
        public string ttitle { get; set; }

        public static List<Teacher> SelectTeacher(string a, int i)
        {
            List<Teacher> list = new List<Teacher>();
            string sql = null;
            if (i == 1)
            {
                sql = "select tno,tname,tsex,tsalary,ttitle from Teacher where tname like :a";
            }
            else sql = "select tno,tname,tsex,tsalary,ttitle from Teacher where tno like :a";
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
                    Teacher c = new Teacher();
                    c.tno = odr.GetString(0);
                    c.tname = odr.GetString(1);
                    c.tsex = odr.GetString(2);
                    c.tsalary = odr.IsDBNull(3) ? 0 : odr.GetInt32(3);
                    c.ttitle = odr.IsDBNull(4) ?"null":odr.GetString(4);
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
        public static int DeleteTeacher(string tno)
        {
            int result = 0;
            string sql = "delete from teacher where tno=:tno";
            OracleParameter[] para = new OracleParameter[]
            {
                new OracleParameter(";tno",OracleDbType.Varchar2,10)
            };
            para[0].Value = tno;
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

        public static int UpdateTeacher(Teacher c)
        {
            int result = 0;
            string sql = "update Teacher set tname=:tname,tsex=:tsex,tsalary=:tsalary,ttitle=:ttitle where tno=:tno";
            OracleParameter[] para = new OracleParameter[]
            {
                new OracleParameter(":tname", OracleDbType.Varchar2, 10),
                new OracleParameter(":tsex", OracleDbType.Varchar2, 3),
                new OracleParameter(":tsalary", OracleDbType.Int32),
                new OracleParameter(":ttitle", OracleDbType.Varchar2, 10),
                new OracleParameter(":tno",OracleDbType.Varchar2,9)
            };
            para[0].Value = c.tname;
            para[1].Value = c.tsex;
            if (c.tsalary == 0)
                para[2].Value = DBNull.Value;
            else para[2].Value = c.tsalary;
            if (string.IsNullOrEmpty(c.ttitle))
                para[3].Value = DBNull.Value;
            else para[3].Value = c.ttitle;
            para[4].Value = c.tno;
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
        public static int AddTeacher(Teacher c)
        {
            int result = 0;
            string sql = "Insert into teacher values(:tno,:tname,:tsex,:tsalary,:ttitle) ";
            OracleParameter[] para = new OracleParameter[]
             {
                new OracleParameter(":tno",OracleDbType.Varchar2,10),
                new OracleParameter(":tname", OracleDbType.Varchar2, 10),
                new OracleParameter(":tsex", OracleDbType.Varchar2, 3),
                new OracleParameter(":tsalary", OracleDbType.Int32),
                new OracleParameter(":ttitle",OracleDbType.Varchar2,10)
             };
            para[0].Value = c.tno;
            para[1].Value = c.tname;
            para[2].Value = c.tsex;
            para[3].Value = c.tsalary;
            if (string.IsNullOrEmpty(c.ttitle))
                para[4].Value = DBNull.Value;
            else para[4].Value = c.ttitle;
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
    }
}
