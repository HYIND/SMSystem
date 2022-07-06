
namespace SMSystem
{
    partial class Adm4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.删除 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.修改 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(927, 119);
            this.panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(679, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 27);
            this.button2.TabIndex = 2;
            this.button2.Text = "添加";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(557, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "姓名查询",
            "工号查询"});
            this.comboBox1.Location = new System.Drawing.Point(34, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(101, 23);
            this.comboBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(154, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(384, 25);
            this.textBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tnoDataGridViewTextBoxColumn,
            this.tnameDataGridViewTextBoxColumn,
            this.tsexDataGridViewTextBoxColumn,
            this.tsalaryDataGridViewTextBoxColumn,
            this.ttitleDataGridViewTextBoxColumn,
            this.删除,
            this.修改});
            this.dataGridView1.DataSource = this.teacherBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 119);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(927, 344);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataSource = typeof(SMSystem.Teacher);
            // 
            // tnoDataGridViewTextBoxColumn
            // 
            this.tnoDataGridViewTextBoxColumn.DataPropertyName = "tno";
            this.tnoDataGridViewTextBoxColumn.HeaderText = "tno";
            this.tnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tnoDataGridViewTextBoxColumn.Name = "tnoDataGridViewTextBoxColumn";
            // 
            // tnameDataGridViewTextBoxColumn
            // 
            this.tnameDataGridViewTextBoxColumn.DataPropertyName = "tname";
            this.tnameDataGridViewTextBoxColumn.HeaderText = "tname";
            this.tnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tnameDataGridViewTextBoxColumn.Name = "tnameDataGridViewTextBoxColumn";
            // 
            // tsexDataGridViewTextBoxColumn
            // 
            this.tsexDataGridViewTextBoxColumn.DataPropertyName = "tsex";
            this.tsexDataGridViewTextBoxColumn.HeaderText = "tsex";
            this.tsexDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tsexDataGridViewTextBoxColumn.Name = "tsexDataGridViewTextBoxColumn";
            this.tsexDataGridViewTextBoxColumn.Width = 80;
            // 
            // tsalaryDataGridViewTextBoxColumn
            // 
            this.tsalaryDataGridViewTextBoxColumn.DataPropertyName = "tsalary";
            this.tsalaryDataGridViewTextBoxColumn.HeaderText = "tsalary";
            this.tsalaryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tsalaryDataGridViewTextBoxColumn.Name = "tsalaryDataGridViewTextBoxColumn";
            // 
            // ttitleDataGridViewTextBoxColumn
            // 
            this.ttitleDataGridViewTextBoxColumn.DataPropertyName = "ttitle";
            this.ttitleDataGridViewTextBoxColumn.HeaderText = "ttitle";
            this.ttitleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ttitleDataGridViewTextBoxColumn.Name = "ttitleDataGridViewTextBoxColumn";
            // 
            // 删除
            // 
            this.删除.HeaderText = "删除";
            this.删除.MinimumWidth = 6;
            this.删除.Name = "删除";
            this.删除.Text = "删除";
            this.删除.UseColumnTextForButtonValue = true;
            this.删除.Width = 80;
            // 
            // 修改
            // 
            this.修改.HeaderText = "修改";
            this.修改.MinimumWidth = 6;
            this.修改.Name = "修改";
            this.修改.Text = "修改";
            this.修改.UseColumnTextForButtonValue = true;
            this.修改.Width = 80;
            // 
            // Adm4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 463);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Adm4";
            this.Text = "教师管理";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn tnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tsexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tsalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ttitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn 删除;
        private System.Windows.Forms.DataGridViewButtonColumn 修改;
    }
}