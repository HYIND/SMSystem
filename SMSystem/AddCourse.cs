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
    public partial class AddCourse : Form
    {
        public AddCourse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Course c = new Course();
            c.Cno = textBox1.Text;
            c.Cname = textBox2.Text;
            c.Cpno = textBox3.Text;
            c.Ccredit = Convert.ToInt32(textBox4.Text);
            if (1 == Course.AddCourse(c))
                MessageBox.Show("添加成功");
            else MessageBox.Show("添加失败");
        }
    }
}
