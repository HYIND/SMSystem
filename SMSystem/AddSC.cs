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
    public partial class AddSC : Form
    {
        public AddSC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) == true
                || string.IsNullOrEmpty(textBox2.Text) == true)
            { MessageBox.Show("学号或课程号不能为空！"); return; }
            SC c = new SC();
            c.sno = textBox1.Text;
            c.cno = textBox2.Text;
            if (string.IsNullOrEmpty(textBox3.Text) == true)
                c.grade = 0;
            else c.grade = Convert.ToInt32(textBox3.Text);
            if(SC.AddSC(c)==1){ MessageBox.Show("添加成功！");this.Close(); }
            else { MessageBox.Show("添加失败！");return; }
        }
    }
}
