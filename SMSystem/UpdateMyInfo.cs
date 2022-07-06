using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMSystem
{
    public partial class UpdateMyInfo : Form
    {
        public UpdateMyInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("确定修改吗？", "请确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result != DialogResult.OK) return;
            Student c = new Student();
            c.Sname = textBox2.Text;
            c.Ssex = textBox3.Text;
            c.Sage = Convert.ToInt32(textBox4.Text);
            c.Sdept = textBox5.Text;
            if (Student.UpdateMyInfo(c, StuUI.mStuUI.user.Sno) == 1)
            { MessageBox.Show("修改信息成功！"); this.Close(); }
            else { MessageBox.Show("修改失败！"); return; }
        }
    }
}
