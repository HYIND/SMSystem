
namespace SMSystem
{
    partial class MyCourse
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btmdropclass = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccreditDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuCourseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuCourseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 130);
            this.panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(673, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(514, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(167, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(332, 25);
            this.textBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "课程名查询",
            "课程号查询"});
            this.comboBox1.Location = new System.Drawing.Point(40, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(111, 23);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(801, 308);
            this.panel2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cnoDataGridViewTextBoxColumn,
            this.cnameDataGridViewTextBoxColumn,
            this.cpnoDataGridViewTextBoxColumn,
            this.gradeDataGridViewTextBoxColumn,
            this.ccreditDataGridViewTextBoxColumn,
            this.btmdropclass});
            this.dataGridView1.DataSource = this.stuCourseBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(801, 308);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // btmdropclass
            // 
            this.btmdropclass.HeaderText = "退选";
            this.btmdropclass.MinimumWidth = 6;
            this.btmdropclass.Name = "btmdropclass";
            this.btmdropclass.Text = "退选";
            this.btmdropclass.UseColumnTextForButtonValue = true;
            this.btmdropclass.Width = 125;
            // 
            // cnoDataGridViewTextBoxColumn
            // 
            this.cnoDataGridViewTextBoxColumn.DataPropertyName = "Cno";
            this.cnoDataGridViewTextBoxColumn.HeaderText = "Cno";
            this.cnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cnoDataGridViewTextBoxColumn.Name = "cnoDataGridViewTextBoxColumn";
            this.cnoDataGridViewTextBoxColumn.Width = 125;
            // 
            // cnameDataGridViewTextBoxColumn
            // 
            this.cnameDataGridViewTextBoxColumn.DataPropertyName = "Cname";
            this.cnameDataGridViewTextBoxColumn.HeaderText = "Cname";
            this.cnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cnameDataGridViewTextBoxColumn.Name = "cnameDataGridViewTextBoxColumn";
            this.cnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // cpnoDataGridViewTextBoxColumn
            // 
            this.cpnoDataGridViewTextBoxColumn.DataPropertyName = "Cpno";
            this.cpnoDataGridViewTextBoxColumn.HeaderText = "Cpno";
            this.cpnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cpnoDataGridViewTextBoxColumn.Name = "cpnoDataGridViewTextBoxColumn";
            this.cpnoDataGridViewTextBoxColumn.Width = 125;
            // 
            // gradeDataGridViewTextBoxColumn
            // 
            this.gradeDataGridViewTextBoxColumn.DataPropertyName = "grade";
            this.gradeDataGridViewTextBoxColumn.HeaderText = "grade";
            this.gradeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gradeDataGridViewTextBoxColumn.Name = "gradeDataGridViewTextBoxColumn";
            this.gradeDataGridViewTextBoxColumn.Width = 125;
            // 
            // ccreditDataGridViewTextBoxColumn
            // 
            this.ccreditDataGridViewTextBoxColumn.DataPropertyName = "Ccredit";
            this.ccreditDataGridViewTextBoxColumn.HeaderText = "Ccredit";
            this.ccreditDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ccreditDataGridViewTextBoxColumn.Name = "ccreditDataGridViewTextBoxColumn";
            this.ccreditDataGridViewTextBoxColumn.Width = 125;
            // 
            // stuCourseBindingSource
            // 
            this.stuCourseBindingSource.DataSource = typeof(SMSystem.StuCourse);
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataSource = typeof(SMSystem.Course);
            // 
            // MyCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 438);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MyCourse";
            this.Text = " 我的已选课程";
            this.Load += new System.EventHandler(this.MyCourse_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuCourseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private System.Windows.Forms.BindingSource stuCourseBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccreditDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn btmdropclass;
    }
}