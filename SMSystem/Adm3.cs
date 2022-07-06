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
    public partial class Adm3 : Form
    {
        public Adm3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex != -1)
                {
                    if (comboBox1.SelectedItem.ToString() == "课程号查询")
                    {
                        this.dataGridView1.DataSource = SC.SelectSC(this.textBox1.Text, 1);
                    }
                    else this.dataGridView1.DataSource = SC.SelectSC(this.textBox1.Text, 2);
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
            SC c = (SC)row.DataBoundItem;
            try
            {
                if (e.ColumnIndex == 3)
                {
                    if (MessageBox.Show("是否确定删除所选选修数据", "请确认信息", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                        return;
                    if (1 == SC.DeleteSC(c.sno, c.cno))
                        MessageBox.Show("删除成功");
                    else MessageBox.Show("删除失败");
                }
                else if (e.ColumnIndex == 4)
                {
                    UpdateSC frm = new UpdateSC();
                    frm.textBox1.Text = c.sno;
                    frm.textBox2.Text = c.cno;
                    frm.textBox3.Text = c.grade.ToString();
                    frm.Show();
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddSC frm = new AddSC();

            frm.Show();
        }
    }
}
