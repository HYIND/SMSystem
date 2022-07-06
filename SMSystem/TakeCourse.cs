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
    public partial class TakeCourse : Form
    {
        public TakeCourse()
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

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            Course c = (Course)row.DataBoundItem;
            try
            {
                if (e.ColumnIndex == 4)
                {
                    if (1 == StuCourse.TakeCourse(c.Cno))
                        MessageBox.Show("选课成功");
                    else MessageBox.Show("选课失败");
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
    }
}
