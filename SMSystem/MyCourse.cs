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
    public partial class MyCourse : Form
    {
        public MyCourse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex != -1)
                {
                    if (comboBox1.SelectedItem.ToString() == "课程名查询")
                    {
                        this.dataGridView1.DataSource = StuCourse.SelectMyCourse(this.textBox1.Text, 1);
                    }
                    else this.dataGridView1.DataSource = StuCourse.SelectMyCourse(this.textBox1.Text, 2);
                }
                else MessageBox.Show("请选择查询方式");
                return;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void MyCourse_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource=StuCourse.ShowMyCourse();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            StuCourse c = (StuCourse)row.DataBoundItem;
            try
            {
                if (e.ColumnIndex == 5)
                {
                    if (MessageBox.Show("确定退选该课程？", "请确认信息", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                        return;
                    if (1 == StuCourse.DropCourse(c.Cno))
                        MessageBox.Show("退选成功");
                    else MessageBox.Show("退选失败");
                    this.dataGridView1.DataSource = StuCourse.ShowMyCourse();
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
