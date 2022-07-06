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
    public partial class Adm4 : Form
    {
        public Adm4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex != -1)
                {
                    if (comboBox1.SelectedItem.ToString() == "姓名查询")
                    {
                        this.dataGridView1.DataSource = Teacher.SelectTeacher(this.textBox1.Text, 1);
                    }
                    else this.dataGridView1.DataSource = Teacher.SelectTeacher(this.textBox1.Text, 2);
                }
                else MessageBox.Show("请选择查询方式");
                return;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddTeacher frm = new AddTeacher();

            frm.Show();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            Teacher c = (Teacher)row.DataBoundItem;
            try
            {
                if (e.ColumnIndex == 5)
                {
                    if (MessageBox.Show("是否确定删除所选学生数据", "请确认信息", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                        return;
                    if (1 == Teacher.DeleteTeacher(c.tno))
                        MessageBox.Show("删除成功");
                    else MessageBox.Show("删除失败");
                }
                else if (e.ColumnIndex == 6)
                {
                    UpdateTeacher frm = new UpdateTeacher();
                    frm.textBox1.Text = c.tno;
                    frm.textBox2.Text = c.tname;
                    frm.textBox3.Text = c.tsex;
                    frm.textBox4.Text = c.tsalary.ToString();
                    frm.textBox5.Text = c.ttitle;
                    frm.Show();
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
    }
}
