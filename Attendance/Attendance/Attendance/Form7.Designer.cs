namespace Attendance
{
    partial class frmAttendanceSummary
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
            this.dgView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dTP2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dTP1 = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addAttendanceDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createPayrollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createPayrollToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgView
            // 
            this.dgView.AllowUserToAddRows = false;
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Location = new System.Drawing.Point(0, 109);
            this.dgView.Name = "dgView";
            this.dgView.Size = new System.Drawing.Size(1109, 578);
            this.dgView.TabIndex = 0;
            this.dgView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgView_CellClick);
            this.dgView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgView_CellFormatting);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAll);
            this.groupBox1.Controls.Add(this.btnFilter);
            this.groupBox1.Controls.Add(this.cmbEmployee);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dTP2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dTP1);
            this.groupBox1.Location = new System.Drawing.Point(4, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1101, 80);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // btnAll
            // 
            this.btnAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.Location = new System.Drawing.Point(962, 43);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(122, 33);
            this.btnAll.TabIndex = 12;
            this.btnAll.Text = "&Load All";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Location = new System.Drawing.Point(834, 43);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(122, 33);
            this.btnFilter.TabIndex = 11;
            this.btnFilter.Text = "&Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Items.AddRange(new object[] {
            "All Employees"});
            this.cmbEmployee.Location = new System.Drawing.Point(792, 10);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(292, 24);
            this.cmbEmployee.TabIndex = 9;
            this.cmbEmployee.SelectedIndexChanged += new System.EventHandler(this.cmbEmployee_SelectedIndexChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(715, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Employee:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(372, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "End Date:";
            // 
            // dTP2
            // 
            this.dTP2.CustomFormat = "yyyy-MM-dd";
            this.dTP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTP2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTP2.Location = new System.Drawing.Point(448, 12);
            this.dTP2.Name = "dTP2";
            this.dTP2.Size = new System.Drawing.Size(200, 22);
            this.dTP2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Start Date:";
            // 
            // dTP1
            // 
            this.dTP1.CustomFormat = "yyyy-MM-dd";
            this.dTP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTP1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTP1.Location = new System.Drawing.Point(86, 11);
            this.dTP1.Name = "dTP1";
            this.dTP1.Size = new System.Drawing.Size(200, 22);
            this.dTP1.TabIndex = 4;
            this.dTP1.Value = new System.DateTime(2017, 8, 8, 0, 0, 0, 0);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAttendanceDetailsToolStripMenuItem,
            this.createPayrollToolStripMenuItem,
            this.createPayrollToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1109, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addAttendanceDetailsToolStripMenuItem
            // 
            this.addAttendanceDetailsToolStripMenuItem.Name = "addAttendanceDetailsToolStripMenuItem";
            this.addAttendanceDetailsToolStripMenuItem.Size = new System.Drawing.Size(143, 20);
            this.addAttendanceDetailsToolStripMenuItem.Text = "Add Attendance Details";
            this.addAttendanceDetailsToolStripMenuItem.Click += new System.EventHandler(this.addAttendanceDetailsToolStripMenuItem_Click);
            // 
            // createPayrollToolStripMenuItem
            // 
            this.createPayrollToolStripMenuItem.Name = "createPayrollToolStripMenuItem";
            this.createPayrollToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.createPayrollToolStripMenuItem.Text = "Print DTRs";
            // 
            // createPayrollToolStripMenuItem1
            // 
            this.createPayrollToolStripMenuItem1.Name = "createPayrollToolStripMenuItem1";
            this.createPayrollToolStripMenuItem1.Size = new System.Drawing.Size(92, 20);
            this.createPayrollToolStripMenuItem1.Text = "Create Payroll";
            this.createPayrollToolStripMenuItem1.Click += new System.EventHandler(this.createPayrollToolStripMenuItem1_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(897, 693);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(200, 33);
            this.btnConfirm.TabIndex = 13;
            this.btnConfirm.Text = "&Confirm Attendance";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtEmpID
            // 
            this.txtEmpID.Location = new System.Drawing.Point(417, 151);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(100, 20);
            this.txtEmpID.TabIndex = 14;
            this.txtEmpID.Visible = false;
            this.txtEmpID.TextChanged += new System.EventHandler(this.txtEmpID_TextChanged);
            // 
            // frmAttendanceSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 729);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmAttendanceSummary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance Summary";
            this.Load += new System.EventHandler(this.frmFetchAttendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dTP2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dTP1;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addAttendanceDetailsToolStripMenuItem;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.ToolStripMenuItem createPayrollToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createPayrollToolStripMenuItem1;
        public System.Windows.Forms.ComboBox cmbEmployee;
        public System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.Button btnAll;
        public System.Windows.Forms.DataGridView dgView;
    }
}