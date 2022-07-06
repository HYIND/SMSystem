using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace SMSystem
{
    public partial class CreditStatistics : Form
    {
        public CreditStatistics()
        {
            InitializeComponent();
        }

        private void CreditStatistics_Load(object sender, EventArgs e)
        {
            string sql1 = "select sum(ccredit) from stuscinfo where sno=" + StuUI.mStuUI.user.Sno;
            string sql2 = "select sum(ccredit) from stuscinfo where sno=" + StuUI.mStuUI.user.Sno
                + " and grade>=60";
            OracleConnection con = new OracleConnection(Program.strCon);
            try
            {
                con.Open();
                OracleCommand cmd1 = new OracleCommand(sql1, con);
                OracleDataReader odr1 = cmd1.ExecuteReader();
                while (odr1.Read())
                {
                    int i;
                    if (odr1.IsDBNull(0)) i = 0;
                    else i = odr1.GetInt16(0);
                    label1.Text = "当前选修课程总学分：" + i.ToString();
                }
                OracleCommand cmd2 = new OracleCommand(sql2, con);
                OracleDataReader odr2 = cmd2.ExecuteReader();
                while (odr2.Read())
                {
                    int i;
                    if (odr2.IsDBNull(0)) i = 0;
                    else i = odr2.GetInt16(0);
                    label2.Text = "已完成选修课程学分：" + i.ToString();
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

            string sql3 = "select cno,cname,ccredit,grade from stuscinfo where sno= "
                + StuUI.mStuUI.user.Sno + " and grade >=60";
            string sql4 = "select cno, cname, ccredit,grade from stuscinfo where sno ="
                + StuUI.mStuUI.user.Sno + " and grade<= 60 or grade is null";
            try
            {
                con.Open();
                OracleCommand cmd3 = new OracleCommand(sql3, con);
                OracleDataReader odr3 = cmd3.ExecuteReader();
                if (odr3.HasRows)
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = odr3;
                    dataGridView1.DataSource = bs;
                }
                else dataGridView1.DataSource = null;
                OracleCommand cmd4 = new OracleCommand(sql4, con);
                OracleDataReader odr4 = cmd4.ExecuteReader();
                if (odr4.HasRows)
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = odr4;
                    dataGridView2.DataSource = bs;
                }
                else dataGridView2.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            this.dataGridView1.Width = Convert.ToInt32(this.Width * 0.5);
            this.dataGridView1.Height = this.Height;
            this.dataGridView2.Width = Convert.ToInt32(this.Width * 0.5);
            this.dataGridView2.Height = this.Height;
        }
    }
}
