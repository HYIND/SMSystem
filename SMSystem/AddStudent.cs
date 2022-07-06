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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student s=new Student();
            if(string.IsNullOrEmpty(textBox1.Text))
            { MessageBox.Show("学号不能为空！");return; }    
            s.Sno = textBox1.Text;
            s.Sname = textBox2.Text;
            s.Ssex = textBox3.Text;
            if (string.IsNullOrEmpty(textBox4.Text))
                s.Sage = 0;
            else s.Sage = Convert.ToInt32(textBox4.Text);
            s.Sdept = textBox5.Text;
            s.password = textBox6.Text;
            if(Student.AddStudent(s)==1)
            { MessageBox.Show("添加成功");return; }
            else MessageBox.Show("添加失败");
        }
    }
}
