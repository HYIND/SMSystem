using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;

namespace SMSystem
{
    public class SC
    {
        public string sno { get; set; }
        public string cno { get; set; }
        public int grade { get; set; }

        public static List<SC> SelectSC(string a, int i)
        {
            List<SC> list = new List<SC>();
            string sql = null;
            if (i == 1)
            {
                sql = "select sno,cno,grade from sc where cno like :a";
            }
            else sql = "select sno,cno,grade from sc where sno like :a";
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
                    SC c = new SC();
                    c.sno = odr.GetString(0);
                    c.cno = odr.GetString(1);
                    if (odr.IsDBNull(2)) c.grade = 0;
                    else c.grade = odr.GetInt32(2);
                    list.Add(c);
                }
            }
            finally
            {
                con.Close();
            }
            return list;
        }
        public static int DeleteSC(string sno, string cno)
        {
            int result = 0;
            string sql = "delete from sc where cno=:cno and sno=:sno";
            OracleParameter[] para = new OracleParameter[]
            {
                new OracleParameter(";cno",OracleDbType.Varchar2,4),
                new OracleParameter(";sno",OracleDbType.Varchar2,9)
            };
            para[0].Value = cno;
            para[1].Value = sno;
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
        public static int UpdateSC(SC c)
        {
            int result = 0;
            string sql = "update SC set grade=:grade where sno=:sno and cno=:cno";
            OracleParameter[] para = new OracleParameter[]
            {
                new OracleParameter(";cno",OracleDbType.Varchar2,4),
                new OracleParameter(";sno",OracleDbType.Varchar2,9),
                new OracleParameter(":grade",OracleDbType.Int32)
            };
            para[0].Value = c.grade;
            para[1].Value = c.sno;
            para[2].Value = c.cno;
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

        public static int AddSC(SC c)
        {
            int result = 0;
            string sql = "Insert into sc values(:sno,:cno,:grade) ";
            OracleParameter[] para = new OracleParameter[]
            {
                new OracleParameter(";sno",OracleDbType.Varchar2,9),
                new OracleParameter(";cno",OracleDbType.Varchar2,4),
                new OracleParameter(":grade",OracleDbType.Int32)
            };
            para[0].Value = c.sno;
            para[1].Value = c.cno;
            para[2].Value = c.grade;
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
