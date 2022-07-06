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
    public partial class StuUI : Form
    {
        public static StuUI mStuUI;
        public StuUI()
        {
            InitializeComponent();
            mStuUI = this;
        }

        public Student user = new Student();
        private void StuUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("确定退出吗？", "退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result != DialogResult.OK)
            {
                e.Cancel = true;
                return;
            }
        }

        private void StuUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.mForm1.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StuUI_Load(object sender, EventArgs e)
        {
        }

        private void StuUI_Load_1(object sender, EventArgs e)
        {
            string sql = "select sno,sname,ssex,sage,sdept from Student where sno =:a";
            OracleParameter[] para = new OracleParameter[]
            {
                new OracleParameter(";a",OracleDbType.Varchar2,10)
            };
            para[0].Value = Form1.username;
            OracleConnection con = new OracleConnection(Program.strCon);
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(sql, con);
                cmd.Parameters.AddRange(para);
                OracleDataReader odr = cmd.ExecuteReader();
                while (odr.Read())
                {
                    this.user.Sno = odr.GetString(0);
                    this.user.Sname = odr.GetString(1);
                    this.user.Ssex = odr.GetString(2);
                    this.user.Sage = odr.GetInt16(3);
                    this.user.Sdept = odr.GetString(4);
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
            StuUI.mStuUI.label1.Text = "欢迎进入学生系统！";
            StuUI.mStuUI.label2.Text = "学号："+user.Sno;
            StuUI.mStuUI.label3.Text = "姓名："+user.Sname;
            StuUI.mStuUI.label4.Text = "性别："+user.Ssex;
            StuUI.mStuUI.label5.Text = "年龄："+user.Sage.ToString();
            StuUI.mStuUI.label6.Text = "所在系："+user.Sdept;
            StuUI.mStuUI.label7.Text = "您的基本信息如下！";
        }

        private void 信息统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 已选课程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void 修改个人信息ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UpdateMyInfo frm = new UpdateMyInfo();

            frm.Show();
            frm.textBox1.Text = user.Sno;
            frm.textBox2.Text = user.Sname;
            frm.textBox3.Text = user.Ssex;
            frm.textBox4.Text = user.Sage.ToString();
            frm.textBox5.Text = user.Sdept;
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateMypassword frm = new UpdateMypassword();

            frm.Show();
        }

        private void 已选课程ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MyCourse frm = new MyCourse();

            frm.Show();
        }

        private void 选修课程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TakeCourse frm = new TakeCourse();

            frm.Show();
        }

        private void 学分统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreditStatistics frm = new CreditStatistics();

            frm.Show();
        }
    }
}
