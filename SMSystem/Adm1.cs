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
    public partial class Adm1 : Form
    {
        public Adm1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex != -1)
                {
                    if (comboBox1.SelectedItem.ToString() == "姓名查询")
                    {
                        this.dataGridView1.DataSource = Student.SelectStudent(this.textBox1.Text, 1);
                    }
                    else this.dataGridView1.DataSource = Student.SelectStudent(this.textBox1.Text, 2);
                }
                else MessageBox.Show("请选择查询方式");
                return;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddStudent frm = new AddStudent();
            frm.Show();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            Student c = (Student)row.DataBoundItem;
            try
            {
                if (e.ColumnIndex == 6)
                {
                    if (MessageBox.Show("是否确定删除所选学生数据", "请确认信息", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                        return;
                    if (1 == Student.DeleteStudent(c.Sno))
                        MessageBox.Show("删除成功");
                    else MessageBox.Show("删除失败");
                }
                else if (e.ColumnIndex == 7)
                {
                    UpdateStudent frm = new UpdateStudent();
                    frm.textBox1.Text = c.Sno;
                    frm.textBox2.Text = c.Sname;
                    frm.textBox3.Text = c.Ssex;
                    frm.textBox4.Text = c.Sage.ToString();
                    frm.textBox5.Text = c.Sdept;
                    frm.textBox6.Text = c.password;
                    frm.Show();
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
    }
}


