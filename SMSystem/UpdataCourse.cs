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
    public partial class UpdateCourse : Form
    {
        public UpdateCourse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Course c = new Course();
            c.Cno = this.textBox1.Text;
            c.Cname=this.textBox2.Text;
            c.Cpno = this.textBox3.Text;
            c.Ccredit = Convert.ToInt32(textBox4.Text);
            if (Course.UpdateCourse(c) == 1)
            {
                MessageBox.Show("修改成功！");
                this.Close();
            }
            else { MessageBox.Show("修改失败"); return; }
        }
    }
}
