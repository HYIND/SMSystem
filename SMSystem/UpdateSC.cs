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
    public partial class UpdateSC : Form
    {
        public UpdateSC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SC c=new SC();
            c.sno = textBox1.Text;
            c.cno = textBox2.Text;
            c.grade = Convert.ToInt32(textBox3.Text);
            if (SC.UpdateSC(c) == 1) { MessageBox.Show("修改成功!"); this.Close(); }
            else { MessageBox.Show("修改失败"); return; }
        }
    }
}
