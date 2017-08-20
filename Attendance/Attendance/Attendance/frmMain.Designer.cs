namespace Attendance
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.attendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printAttendanceDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAttendanceDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dTRGenerationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payrollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deductionDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeDeductionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employerContributionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeePayrollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.attendanceToolStripMenuItem,
            this.payrollToolStripMenuItem,
            this.windowsMenu,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.windowsMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(817, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // attendanceToolStripMenuItem
            // 
            this.attendanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printAttendanceDetailToolStripMenuItem,
            this.addAttendanceDetailToolStripMenuItem});
            this.attendanceToolStripMenuItem.Name = "attendanceToolStripMenuItem";
            this.attendanceToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.attendanceToolStripMenuItem.Text = "Attendance";
            // 
            // printAttendanceDetailToolStripMenuItem
            // 
            this.printAttendanceDetailToolStripMenuItem.Name = "printAttendanceDetailToolStripMenuItem";
            this.printAttendanceDetailToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.printAttendanceDetailToolStripMenuItem.Text = "Print Attendance Detail";
            this.printAttendanceDetailToolStripMenuItem.Click += new System.EventHandler(this.printAttendanceDetailToolStripMenuItem_Click);
            // 
            // addAttendanceDetailToolStripMenuItem
            // 
            this.addAttendanceDetailToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDetailsToolStripMenuItem,
            this.dTRGenerationToolStripMenuItem});
            this.addAttendanceDetailToolStripMenuItem.Name = "addAttendanceDetailToolStripMenuItem";
            this.addAttendanceDetailToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.addAttendanceDetailToolStripMenuItem.Text = "Attendance Details";
            this.addAttendanceDetailToolStripMenuItem.Click += new System.EventHandler(this.addAttendanceDetailToolStripMenuItem_Click);
            // 
            // addDetailsToolStripMenuItem
            // 
            this.addDetailsToolStripMenuItem.Name = "addDetailsToolStripMenuItem";
            this.addDetailsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.addDetailsToolStripMenuItem.Text = "Add Attendance";
            this.addDetailsToolStripMenuItem.Click += new System.EventHandler(this.addDetailsToolStripMenuItem_Click);
            // 
            // dTRGenerationToolStripMenuItem
            // 
            this.dTRGenerationToolStripMenuItem.Name = "dTRGenerationToolStripMenuItem";
            this.dTRGenerationToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.dTRGenerationToolStripMenuItem.Text = "DTR Generation";
            this.dTRGenerationToolStripMenuItem.Click += new System.EventHandler(this.dTRGenerationToolStripMenuItem_Click);
            // 
            // payrollToolStripMenuItem
            // 
            this.payrollToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deductionDetailsToolStripMenuItem,
            this.employeeDeductionToolStripMenuItem,
            this.employerContributionToolStripMenuItem,
            this.employeePayrollToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.payrollToolStripMenuItem.Name = "payrollToolStripMenuItem";
            this.payrollToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.payrollToolStripMenuItem.Text = "Payroll";
            // 
            // deductionDetailsToolStripMenuItem
            // 
            this.deductionDetailsToolStripMenuItem.Name = "deductionDetailsToolStripMenuItem";
            this.deductionDetailsToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.deductionDetailsToolStripMenuItem.Text = "Deduction Details";
            this.deductionDetailsToolStripMenuItem.Click += new System.EventHandler(this.deductionDetailsToolStripMenuItem_Click);
            // 
            // employeeDeductionToolStripMenuItem
            // 
            this.employeeDeductionToolStripMenuItem.Name = "employeeDeductionToolStripMenuItem";
            this.employeeDeductionToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.employeeDeductionToolStripMenuItem.Text = "Employee Deduction";
            this.employeeDeductionToolStripMenuItem.Click += new System.EventHandler(this.employeeDeductionToolStripMenuItem_Click);
            // 
            // employerContributionToolStripMenuItem
            // 
            this.employerContributionToolStripMenuItem.Name = "employerContributionToolStripMenuItem";
            this.employerContributionToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.employerContributionToolStripMenuItem.Text = "Employer Contribution";
            this.employerContributionToolStripMenuItem.Click += new System.EventHandler(this.employerContributionToolStripMenuItem_Click);
            // 
            // employeePayrollToolStripMenuItem
            // 
            this.employeePayrollToolStripMenuItem.Name = "employeePayrollToolStripMenuItem";
            this.employeePayrollToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.employeePayrollToolStripMenuItem.Text = "Employee Payroll";
            this.employeePayrollToolStripMenuItem.Click += new System.EventHandler(this.employeePayrollToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.reportToolStripMenuItem.Text = "Report Generation";
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeAllToolStripMenuItem});
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(68, 20);
            this.windowsMenu.Text = "&Windows";
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.closeAllToolStripMenuItem.Text = "C&lose All";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator8,
            this.aboutToolStripMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(44, 20);
            this.helpMenu.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("indexToolStripMenuItem.Image")));
            this.indexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(165, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.aboutToolStripMenuItem.Text = "&About ... ...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.DodgerBlue;
            this.statusStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(817, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(355, 17);
            this.toolStripStatusLabel1.Text = "  AP System Version 1.0 of MUREY IT SOLUTIONS";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AP System v1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem attendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printAttendanceDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAttendanceDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payrollToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deductionDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeDeductionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employerContributionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeePayrollToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem addDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dTRGenerationToolStripMenuItem;
    }
}



