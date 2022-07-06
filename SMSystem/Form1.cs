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
    public partial class Form1 : Form
    {
        public static Form1 mForm1;
        public Form1()
        {
            InitializeComponent();
            mForm1 = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
        public static string username;
        private void button1_Click(object sender, EventArgs e)
        {
            username = this.textBox1.Text;
            string password = this.textBox2.Text;
            if (comboBox1.SelectedIndex != -1)
            {
                OracleConnection con = new OracleConnection(Program.strCon);
                if (comboBox1.SelectedItem.ToString() == "管理员")
                {
                    string sql = "select* from adminlist where ano='" + username + "'and apassword='" + password+"'";
                    try
                    {
                        con.Open();
                        OracleCommand cmd1 = new OracleCommand(sql, con);
                        OracleDataReader odr1 = cmd1.ExecuteReader();
                        if (odr1.HasRows)
                        {
                            this.Visible = false;
                            MessageBox.Show("登录成功！");
                            ADMUI frm = new ADMUI();
                            frm.Show();
                        }
                        else { MessageBox.Show("用户名或密码错误"); return; }
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
                else if (comboBox1.SelectedItem.ToString() == "学生")
                {
                    string sql2 = "select* from student where sno='" + username + "'and password='" + password+"'";
                    try
                    {
                        con.Open();
                        OracleCommand cmd2 = new OracleCommand(sql2, con);
                        OracleDataReader odr2 = cmd2.ExecuteReader();
                        if (odr2.HasRows)
                        {
                            this.Visible = false;
                            MessageBox.Show("登录成功！");
                            StuUI frm = new StuUI();
                            frm.Show();
                        }
                        else { MessageBox.Show("用户名或密码错误"); return; }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        con.Close();
                    }
                    return;
                }
            }
            else
            { MessageBox.Show("请选择角色"); return; }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
