namespace Attendance
{
    partial class frmAttendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAttendance));
            this.btnConnection = new System.Windows.Forms.Button();
            this.dgView = new System.Windows.Forms.DataGridView();
            this.grpData = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtDetector = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.TimeOutPM = new System.Windows.Forms.TextBox();
            this.TimeInAM = new System.Windows.Forms.TextBox();
            this.TimeOutAM = new System.Windows.Forms.TextBox();
            this.TimeInPM = new System.Windows.Forms.TextBox();
            this.txtDateTime = new System.Windows.Forms.TextBox();
            this.dgViewAttendance = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attendanceSheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dTRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payrollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDeductionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaryComputationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payrollToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.printPayrollsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.grpData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewAttendance)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnection
            // 
            this.btnConnection.Location = new System.Drawing.Point(158, 274);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(75, 23);
            this.btnConnection.TabIndex = 0;
            this.btnConnection.Text = "button1";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Visible = false;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // dgView
            // 
            this.dgView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgView.Location = new System.Drawing.Point(33, 48);
            this.dgView.Name = "dgView";
            this.dgView.Size = new System.Drawing.Size(608, 193);
            this.dgView.TabIndex = 1;
            this.dgView.Visible = false;
            this.dgView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgView_CellClick);
            this.dgView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgView_CellContentClick);
            this.dgView.SelectionChanged += new System.EventHandler(this.dgView_SelectionChanged);
            this.dgView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgView_KeyDown);
            // 
            // grpData
            // 
            this.grpData.Controls.Add(this.textBox1);
            this.grpData.Controls.Add(this.label2);
            this.grpData.Controls.Add(this.txtCode);
            this.grpData.Controls.Add(this.pictureBox1);
            this.grpData.Controls.Add(this.button4);
            this.grpData.Controls.Add(this.button3);
            this.grpData.Controls.Add(this.txtDetector);
            this.grpData.Controls.Add(this.button2);
            this.grpData.Controls.Add(this.lblDate);
            this.grpData.Controls.Add(this.txtDate);
            this.grpData.Controls.Add(this.lblTime);
            this.grpData.Controls.Add(this.txtID);
            this.grpData.Controls.Add(this.txtTime);
            this.grpData.Controls.Add(this.lblName);
            this.grpData.Controls.Add(this.button1);
            this.grpData.Controls.Add(this.txtName);
            this.grpData.Controls.Add(this.TimeOutPM);
            this.grpData.Controls.Add(this.TimeInAM);
            this.grpData.Controls.Add(this.TimeOutAM);
            this.grpData.Controls.Add(this.TimeInPM);
            this.grpData.Controls.Add(this.btnConnection);
            this.grpData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpData.Location = new System.Drawing.Point(627, 23);
            this.grpData.Name = "grpData";
            this.grpData.Size = new System.Drawing.Size(383, 353);
            this.grpData.TabIndex = 2;
            this.grpData.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(8, 77);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(364, 42);
            this.textBox1.TabIndex = 29;
            this.textBox1.Text = "Note: Enter SMS Code and Press F1 to Time In for AM, F2 to Time Out AM, F3 to Tim" +
    "e In PM and F4 to Time Out PM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 28;
            this.label2.Text = "Code:";
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(93, 198);
            this.txtCode.Multiline = true;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(278, 27);
            this.txtCode.TabIndex = 0;
            this.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            this.txtCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(109, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(92, 433);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(276, 37);
            this.button4.TabIndex = 21;
            this.button4.Text = "Time Out PM (F4)";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(93, 390);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(276, 37);
            this.button3.TabIndex = 20;
            this.button3.Text = "Time In PM (F3)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtDetector
            // 
            this.txtDetector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetector.Location = new System.Drawing.Point(131, 302);
            this.txtDetector.Multiline = true;
            this.txtDetector.Name = "txtDetector";
            this.txtDetector.Size = new System.Drawing.Size(187, 31);
            this.txtDetector.TabIndex = 19;
            this.txtDetector.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDetector.Visible = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(93, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(276, 37);
            this.button2.TabIndex = 17;
            this.button2.Text = "Time Out AM (F2)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(4, 132);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(42, 15);
            this.lblDate.TabIndex = 15;
            this.lblDate.Text = "Date:";
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.ForeColor = System.Drawing.Color.Red;
            this.txtDate.Location = new System.Drawing.Point(93, 161);
            this.txtDate.Multiline = true;
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(278, 27);
            this.txtDate.TabIndex = 14;
            this.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(4, 169);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(43, 15);
            this.lblTime.TabIndex = 13;
            this.lblTime.Text = "Time:";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(137, 368);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(187, 31);
            this.txtID.TabIndex = 16;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtID.Visible = false;
            // 
            // txtTime
            // 
            this.txtTime.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.ForeColor = System.Drawing.Color.Red;
            this.txtTime.Location = new System.Drawing.Point(94, 124);
            this.txtTime.Multiline = true;
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(278, 27);
            this.txtTime.TabIndex = 12;
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(4, 238);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(75, 15);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Employee:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(93, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(276, 37);
            this.button1.TabIndex = 10;
            this.button1.Text = "Time In AM (F1)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(93, 231);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(278, 27);
            this.txtName.TabIndex = 9;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TimeOutPM
            // 
            this.TimeOutPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeOutPM.Location = new System.Drawing.Point(128, 233);
            this.TimeOutPM.Multiline = true;
            this.TimeOutPM.Name = "TimeOutPM";
            this.TimeOutPM.Size = new System.Drawing.Size(187, 31);
            this.TimeOutPM.TabIndex = 25;
            this.TimeOutPM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TimeOutPM.Visible = false;
            // 
            // TimeInAM
            // 
            this.TimeInAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeInAM.Location = new System.Drawing.Point(160, 156);
            this.TimeInAM.Multiline = true;
            this.TimeInAM.Name = "TimeInAM";
            this.TimeInAM.Size = new System.Drawing.Size(187, 31);
            this.TimeInAM.TabIndex = 0;
            this.TimeInAM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TimeInAM.Visible = false;
            this.TimeInAM.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TimeInAM_KeyDown);
            // 
            // TimeOutAM
            // 
            this.TimeOutAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeOutAM.Location = new System.Drawing.Point(128, 167);
            this.TimeOutAM.Multiline = true;
            this.TimeOutAM.Name = "TimeOutAM";
            this.TimeOutAM.Size = new System.Drawing.Size(187, 31);
            this.TimeOutAM.TabIndex = 23;
            this.TimeOutAM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TimeOutAM.Visible = false;
            // 
            // TimeInPM
            // 
            this.TimeInPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeInPM.Location = new System.Drawing.Point(128, 200);
            this.TimeInPM.Multiline = true;
            this.TimeInPM.Name = "TimeInPM";
            this.TimeInPM.Size = new System.Drawing.Size(187, 31);
            this.TimeInPM.TabIndex = 22;
            this.TimeInPM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TimeInPM.Visible = false;
            // 
            // txtDateTime
            // 
            this.txtDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateTime.Location = new System.Drawing.Point(378, 297);
            this.txtDateTime.Multiline = true;
            this.txtDateTime.Name = "txtDateTime";
            this.txtDateTime.Size = new System.Drawing.Size(187, 31);
            this.txtDateTime.TabIndex = 18;
            this.txtDateTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDateTime.Visible = false;
            // 
            // dgViewAttendance
            // 
            this.dgViewAttendance.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgViewAttendance.Location = new System.Drawing.Point(16, 28);
            this.dgViewAttendance.Name = "dgViewAttendance";
            this.dgViewAttendance.Size = new System.Drawing.Size(609, 347);
            this.dgViewAttendance.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "Employee\'s Attendance for the Day";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.payrollToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.heloToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1018, 24);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.attendanceSheetToolStripMenuItem,
            this.dTRToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.fileToolStripMenuItem.Text = "Attendance";
            // 
            // attendanceSheetToolStripMenuItem
            // 
            this.attendanceSheetToolStripMenuItem.Name = "attendanceSheetToolStripMenuItem";
            this.attendanceSheetToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.attendanceSheetToolStripMenuItem.Text = "Print Attendance Sheet";
            this.attendanceSheetToolStripMenuItem.Click += new System.EventHandler(this.attendanceSheetToolStripMenuItem_Click);
            // 
            // dTRToolStripMenuItem
            // 
            this.dTRToolStripMenuItem.Name = "dTRToolStripMenuItem";
            this.dTRToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.dTRToolStripMenuItem.Text = "Add Attendance Detail";
            this.dTRToolStripMenuItem.Click += new System.EventHandler(this.dTRToolStripMenuItem_Click);
            // 
            // payrollToolStripMenuItem
            // 
            this.payrollToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDeductionsToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.salaryComputationToolStripMenuItem,
            this.payrollToolStripMenuItem1,
            this.printPayrollsToolStripMenuItem});
            this.payrollToolStripMenuItem.Name = "payrollToolStripMenuItem";
            this.payrollToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.payrollToolStripMenuItem.Text = "Payroll";
            // 
            // addDeductionsToolStripMenuItem
            // 
            this.addDeductionsToolStripMenuItem.Name = "addDeductionsToolStripMenuItem";
            this.addDeductionsToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.addDeductionsToolStripMenuItem.Text = "Deduction Details";
            this.addDeductionsToolStripMenuItem.Click += new System.EventHandler(this.addDeductionsToolStripMenuItem_Click);
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.transactionToolStripMenuItem.Text = "Employee Deductions";
            this.transactionToolStripMenuItem.Click += new System.EventHandler(this.transactionToolStripMenuItem_Click);
            // 
            // salaryComputationToolStripMenuItem
            // 
            this.salaryComputationToolStripMenuItem.Name = "salaryComputationToolStripMenuItem";
            this.salaryComputationToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.salaryComputationToolStripMenuItem.Text = "Employer Contributions";
            this.salaryComputationToolStripMenuItem.Click += new System.EventHandler(this.salaryComputationToolStripMenuItem_Click);
            // 
            // payrollToolStripMenuItem1
            // 
            this.payrollToolStripMenuItem1.Name = "payrollToolStripMenuItem1";
            this.payrollToolStripMenuItem1.Size = new System.Drawing.Size(200, 22);
            this.payrollToolStripMenuItem1.Text = "Generate Payroll";
            this.payrollToolStripMenuItem1.Click += new System.EventHandler(this.payrollToolStripMenuItem1_Click);
            // 
            // printPayrollsToolStripMenuItem
            // 
            this.printPayrollsToolStripMenuItem.Name = "printPayrollsToolStripMenuItem";
            this.printPayrollsToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.printPayrollsToolStripMenuItem.Text = "Print Payrolls";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // heloToolStripMenuItem
            // 
            this.heloToolStripMenuItem.Name = "heloToolStripMenuItem";
            this.heloToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.heloToolStripMenuItem.Text = "Help";
            // 
            // frmAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 384);
            this.Controls.Add(this.txtDateTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgViewAttendance);
            this.Controls.Add(this.grpData);
            this.Controls.Add(this.dgView);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmAttendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAttendance_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TimeInAM_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.grpData.ResumeLayout(false);
            this.grpData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewAttendance)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.DataGridView dgView;
        private System.Windows.Forms.GroupBox grpData;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgViewAttendance;
        private System.Windows.Forms.TextBox txtDateTime;
        private System.Windows.Forms.TextBox txtDetector;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox TimeOutPM;
        private System.Windows.Forms.TextBox TimeInAM;
        private System.Windows.Forms.TextBox TimeOutAM;
        private System.Windows.Forms.TextBox TimeInPM;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.ToolStripMenuItem attendanceSheetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dTRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payrollToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDeductionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaryComputationToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payrollToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem printPayrollsToolStripMenuItem;
    }
}

