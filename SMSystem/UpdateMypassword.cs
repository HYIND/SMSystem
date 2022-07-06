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
    public partial class UpdateMypassword : Form
    {
        public UpdateMypassword()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("确定修改吗？", "请确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result != DialogResult.OK) return;
            if (textBox2.Text == textBox3.Text)
            {
                string str1 = textBox1.Text;
                string str2 = textBox2.Text;
                if(Student.UpdataMypassword(str1,str2,StuUI.mStuUI.user.Sno)==1)
                { MessageBox.Show("修改成功！");this.Close(); }
                else return; 
            }
            else { MessageBox.Show("两次输入的密码不一致！");return; }
        }
    }
}
