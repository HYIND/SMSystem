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
    public partial class AddTeacher : Form
    {
        public AddTeacher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Teacher c = new Teacher();
            if (string.IsNullOrEmpty(textBox1.Text)
                || string.IsNullOrEmpty(textBox2.Text)
                || string.IsNullOrEmpty(textBox2.Text))
            { MessageBox.Show("工号或姓名或性别不能为空！"); return; }
            c.tno = textBox1.Text;
            c.tname = textBox2.Text;
            c.tsex = textBox3.Text;
            c.tsalary = string.IsNullOrEmpty(textBox4.Text) ? 0 : Convert.ToInt32(textBox4.Text);
            c.ttitle = textBox5.Text;
            if (Teacher.AddTeacher(c) == 1)
            { MessageBox.Show("添加成功"); return; }
            else MessageBox.Show("添加失败");
        }
    }
}
