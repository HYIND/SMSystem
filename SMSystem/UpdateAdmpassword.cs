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
    public partial class UpdateAdmpassword : Form
    {
        public UpdateAdmpassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("确定修改吗？", "请确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result != DialogResult.OK) return;
            else
            { OracleConnection con = new OracleConnection(Program.strCon);
                {
                    try
                    {
                        string sql = "update set Adminlist set apassword=" + textBox1.Text + " where ano=" + ADMUI.mAdmUI.Text;
                        con.Open();
                        OracleCommand cmd = new OracleCommand(sql, con);
                    }
                    catch (Exception ex)
                    { MessageBox.Show(ex.Message); }
                    finally
                    { con.Close(); } 
                }

            }
        }
    }

}

