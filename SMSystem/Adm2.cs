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
    public partial class Adm2 : Form
    {
        public Adm2()
        {
            InitializeComponent();
        }

        private void Adm2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex != -1)
                {
                    if (comboBox1.SelectedItem.ToString() == "课程名查询")
                    {
                        this.dataGridView1.DataSource = Course.SelectCourse(this.textBox1.Text, 1);
                    }
                    else this.dataGridView1.DataSource = Course.SelectCourse(this.textBox1.Text, 2);
                }
                else MessageBox.Show("请选择查询方式");
                return;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void courseBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void courseBindingSource1_CurrentChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            Course c = (Course)row.DataBoundItem;
            try
            {
                if (e.ColumnIndex == 4)
                { 
                    if (MessageBox.Show("是否确定删除所选课程数据", "请确认信息", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                        return;
                    if (1 == Course.DeleteCourse(c.Cno))
                        MessageBox.Show("删除成功");
                    else MessageBox.Show("删除失败");
                }
                else if (e.ColumnIndex == 5)
                { UpdateCourse frm = new UpdateCourse();
                    frm.textBox1.Text = c.Cno;
                    frm.textBox2.Text = c.Cname;
                    frm.textBox3.Text = c.Cpno;
                    frm.textBox4.Text = c.Ccredit.ToString();
                    frm.Show();
                }
            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddCourse frm = new AddCourse();
            frm.Show();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
