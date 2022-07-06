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
    public partial class UpdateTeacher : Form
    {
        public UpdateTeacher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Teacher c = new Teacher();
            if (string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
            { MessageBox.Show("姓名或性别不能为空！"); return; }
            c.tno = this.textBox1.Text;
            c.tname = this.textBox2.Text;
            c.tsex = this.textBox3.Text;
            if (string.IsNullOrEmpty(textBox4.Text)) c.tsalary = 0;
            else c.tsalary = Convert.ToInt32(textBox4.Text);
            c.ttitle = this.textBox5.Text;
            if (Teacher.UpdateTeacher(c) == 1)
            {
                MessageBox.Show("修改成功！");
                this.Close();
            }
            else { MessageBox.Show("修改失败"); return; }
        }
    }
}
