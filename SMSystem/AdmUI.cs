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
    public partial class ADMUI : Form
    {
        public static ADMUI mAdmUI;
        public ADMUI()
        {
            InitializeComponent();
            mAdmUI = this;
        }
        public string user=Form1.username;

        private void ADMUI_Load(object sender, EventArgs e)
        {
            
        }

        private void ADMUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("确定退出吗？", "退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result != DialogResult.OK)
            {
                e.Cancel = true;
                return;
            }
        }

        private void ADMUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.mForm1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Adm1 frm = new Adm1();

            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Adm2 frm = new Adm2();

            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Adm3 frm = new Adm3();

            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Adm4 frm = new Adm4();

            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Adm5 frm = new Adm5();

            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
