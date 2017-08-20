namespace Attendance
{
    partial class frmPayroll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayroll));
            this.grpData = new System.Windows.Forms.GroupBox();
            this.btnSaveSalary = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.cmbPayFrequency = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDeductID = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtDeduction = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLegalHolidayCompute = new System.Windows.Forms.TextBox();
            this.txtLegalHoliday = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSpecialHolidayCompute = new System.Windows.Forms.TextBox();
            this.txtSpecialHoliday = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRegularOTCompute = new System.Windows.Forms.TextBox();
            this.txtRegularOT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNoOfDaysCompute = new System.Windows.Forms.TextBox();
            this.txtNoOfDays = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGrossPay = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgViewDeduction = new System.Windows.Forms.DataGridView();
            this.btnAddDeduction = new System.Windows.Forms.Button();
            this.txtNetPay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dgViewEmployerContribution = new System.Windows.Forms.DataGridView();
            this.btnAddContribution = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.grpData.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewDeduction)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewEmployerContribution)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpData
            // 
            this.grpData.Controls.Add(this.btnSaveSalary);
            this.grpData.Controls.Add(this.label2);
            this.grpData.Controls.Add(this.txtSalary);
            this.grpData.Controls.Add(this.cmbPayFrequency);
            this.grpData.Controls.Add(this.label4);
            this.grpData.Controls.Add(this.button5);
            this.grpData.Controls.Add(this.label1);
            this.grpData.Controls.Add(this.txtName);
            this.grpData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpData.Location = new System.Drawing.Point(3, -4);
            this.grpData.Name = "grpData";
            this.grpData.Size = new System.Drawing.Size(916, 109);
            this.grpData.TabIndex = 6;
            this.grpData.TabStop = false;
            // 
            // btnSaveSalary
            // 
            this.btnSaveSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSalary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveSalary.Location = new System.Drawing.Point(635, 75);
            this.btnSaveSalary.Name = "btnSaveSalary";
            this.btnSaveSalary.Size = new System.Drawing.Size(175, 26);
            this.btnSaveSalary.TabIndex = 37;
            this.btnSaveSalary.Text = "Save Salary";
            this.btnSaveSalary.UseVisualStyleBackColor = true;
            this.btnSaveSalary.Click += new System.EventHandler(this.btnSaveSalary_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(576, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 33;
            this.label2.Text = "Salary:";
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.ForeColor = System.Drawing.Color.Red;
            this.txtSalary.Location = new System.Drawing.Point(635, 44);
            this.txtSalary.Multiline = true;
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(268, 22);
            this.txtSalary.TabIndex = 32;
            this.txtSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbPayFrequency
            // 
            this.cmbPayFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPayFrequency.FormattingEnabled = true;
            this.cmbPayFrequency.Location = new System.Drawing.Point(125, 45);
            this.cmbPayFrequency.Name = "cmbPayFrequency";
            this.cmbPayFrequency.Size = new System.Drawing.Size(322, 24);
            this.cmbPayFrequency.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 30;
            this.label4.Text = "Pay Frequency:";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(527, 16);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(48, 26);
            this.button5.TabIndex = 23;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Employee Name:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Red;
            this.txtName.Location = new System.Drawing.Point(125, 15);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(396, 26);
            this.txtName.TabIndex = 14;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDeductID
            // 
            this.txtDeductID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.txtDeductID.ForeColor = System.Drawing.Color.Red;
            this.txtDeductID.Location = new System.Drawing.Point(797, 430);
            this.txtDeductID.Multiline = true;
            this.txtDeductID.Name = "txtDeductID";
            this.txtDeductID.Size = new System.Drawing.Size(89, 22);
            this.txtDeductID.TabIndex = 28;
            this.txtDeductID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDeductID.Visible = false;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.txtID.ForeColor = System.Drawing.Color.Red;
            this.txtID.Location = new System.Drawing.Point(797, 402);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(89, 22);
            this.txtID.TabIndex = 27;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtID.Visible = false;
            // 
            // txtDeduction
            // 
            this.txtDeduction.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.txtDeduction.ForeColor = System.Drawing.Color.Red;
            this.txtDeduction.Location = new System.Drawing.Point(797, 377);
            this.txtDeduction.Multiline = true;
            this.txtDeduction.Name = "txtDeduction";
            this.txtDeduction.Size = new System.Drawing.Size(78, 19);
            this.txtDeduction.TabIndex = 12;
            this.txtDeduction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDeduction.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLegalHolidayCompute);
            this.groupBox1.Controls.Add(this.txtLegalHoliday);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtSpecialHolidayCompute);
            this.groupBox1.Controls.Add(this.txtSpecialHoliday);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtRegularOTCompute);
            this.groupBox1.Controls.Add(this.txtRegularOT);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtNoOfDaysCompute);
            this.groupBox1.Controls.Add(this.txtNoOfDays);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtRate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtGrossPay);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(3, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 411);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // txtLegalHolidayCompute
            // 
            this.txtLegalHolidayCompute.Enabled = false;
            this.txtLegalHolidayCompute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLegalHolidayCompute.ForeColor = System.Drawing.Color.Red;
            this.txtLegalHolidayCompute.Location = new System.Drawing.Point(250, 138);
            this.txtLegalHolidayCompute.Multiline = true;
            this.txtLegalHolidayCompute.Name = "txtLegalHolidayCompute";
            this.txtLegalHolidayCompute.Size = new System.Drawing.Size(135, 26);
            this.txtLegalHolidayCompute.TabIndex = 48;
            this.txtLegalHolidayCompute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLegalHoliday
            // 
            this.txtLegalHoliday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLegalHoliday.ForeColor = System.Drawing.Color.Red;
            this.txtLegalHoliday.Location = new System.Drawing.Point(116, 138);
            this.txtLegalHoliday.Multiline = true;
            this.txtLegalHoliday.Name = "txtLegalHoliday";
            this.txtLegalHoliday.Size = new System.Drawing.Size(135, 26);
            this.txtLegalHoliday.TabIndex = 47;
            this.txtLegalHoliday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 144);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 16);
            this.label11.TabIndex = 46;
            this.label11.Text = "Legal Holiday:";
            // 
            // txtSpecialHolidayCompute
            // 
            this.txtSpecialHolidayCompute.Enabled = false;
            this.txtSpecialHolidayCompute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpecialHolidayCompute.ForeColor = System.Drawing.Color.Red;
            this.txtSpecialHolidayCompute.Location = new System.Drawing.Point(250, 106);
            this.txtSpecialHolidayCompute.Multiline = true;
            this.txtSpecialHolidayCompute.Name = "txtSpecialHolidayCompute";
            this.txtSpecialHolidayCompute.Size = new System.Drawing.Size(135, 26);
            this.txtSpecialHolidayCompute.TabIndex = 45;
            this.txtSpecialHolidayCompute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSpecialHoliday
            // 
            this.txtSpecialHoliday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpecialHoliday.ForeColor = System.Drawing.Color.Red;
            this.txtSpecialHoliday.Location = new System.Drawing.Point(116, 106);
            this.txtSpecialHoliday.Multiline = true;
            this.txtSpecialHoliday.Name = "txtSpecialHoliday";
            this.txtSpecialHoliday.Size = new System.Drawing.Size(135, 26);
            this.txtSpecialHoliday.TabIndex = 44;
            this.txtSpecialHoliday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 16);
            this.label10.TabIndex = 43;
            this.label10.Text = "Special Holiday:";
            // 
            // txtRegularOTCompute
            // 
            this.txtRegularOTCompute.Enabled = false;
            this.txtRegularOTCompute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegularOTCompute.ForeColor = System.Drawing.Color.Red;
            this.txtRegularOTCompute.Location = new System.Drawing.Point(250, 74);
            this.txtRegularOTCompute.Multiline = true;
            this.txtRegularOTCompute.Name = "txtRegularOTCompute";
            this.txtRegularOTCompute.Size = new System.Drawing.Size(135, 26);
            this.txtRegularOTCompute.TabIndex = 42;
            this.txtRegularOTCompute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRegularOT
            // 
            this.txtRegularOT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegularOT.ForeColor = System.Drawing.Color.Red;
            this.txtRegularOT.Location = new System.Drawing.Point(116, 74);
            this.txtRegularOT.Multiline = true;
            this.txtRegularOT.Name = "txtRegularOT";
            this.txtRegularOT.Size = new System.Drawing.Size(135, 26);
            this.txtRegularOT.TabIndex = 41;
            this.txtRegularOT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 16);
            this.label9.TabIndex = 40;
            this.label9.Text = "Regular OT:";
            // 
            // txtNoOfDaysCompute
            // 
            this.txtNoOfDaysCompute.Enabled = false;
            this.txtNoOfDaysCompute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoOfDaysCompute.ForeColor = System.Drawing.Color.Red;
            this.txtNoOfDaysCompute.Location = new System.Drawing.Point(250, 42);
            this.txtNoOfDaysCompute.Multiline = true;
            this.txtNoOfDaysCompute.Name = "txtNoOfDaysCompute";
            this.txtNoOfDaysCompute.Size = new System.Drawing.Size(135, 26);
            this.txtNoOfDaysCompute.TabIndex = 39;
            this.txtNoOfDaysCompute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNoOfDays
            // 
            this.txtNoOfDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoOfDays.ForeColor = System.Drawing.Color.Red;
            this.txtNoOfDays.Location = new System.Drawing.Point(116, 42);
            this.txtNoOfDays.Multiline = true;
            this.txtNoOfDays.Name = "txtNoOfDays";
            this.txtNoOfDays.Size = new System.Drawing.Size(135, 26);
            this.txtNoOfDays.TabIndex = 38;
            this.txtNoOfDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 16);
            this.label8.TabIndex = 37;
            this.label8.Text = "No. of Days:";
            // 
            // txtRate
            // 
            this.txtRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.ForeColor = System.Drawing.Color.Red;
            this.txtRate.Location = new System.Drawing.Point(116, 10);
            this.txtRate.Multiline = true;
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(135, 26);
            this.txtRate.TabIndex = 36;
            this.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRate.TextChanged += new System.EventHandler(this.txtRate_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 35;
            this.label7.Text = "Rate:";
            // 
            // txtGrossPay
            // 
            this.txtGrossPay.Enabled = false;
            this.txtGrossPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrossPay.ForeColor = System.Drawing.Color.Red;
            this.txtGrossPay.Location = new System.Drawing.Point(116, 170);
            this.txtGrossPay.Multiline = true;
            this.txtGrossPay.Name = "txtGrossPay";
            this.txtGrossPay.Size = new System.Drawing.Size(150, 26);
            this.txtGrossPay.TabIndex = 34;
            this.txtGrossPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "Gross Pay:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(4, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 40);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(49, 14);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(284, 20);
            this.textBox1.TabIndex = 32;
            this.textBox1.Text = "Regular Pay";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Location = new System.Drawing.Point(398, 103);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(256, 40);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(6, 14);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(238, 20);
            this.textBox3.TabIndex = 32;
            this.textBox3.Text = "Employee Contribution";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgViewDeduction);
            this.groupBox4.Controls.Add(this.btnAddDeduction);
            this.groupBox4.Controls.Add(this.txtNetPay);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(397, 142);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(257, 411);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            // 
            // dgViewDeduction
            // 
            this.dgViewDeduction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewDeduction.Location = new System.Drawing.Point(7, 38);
            this.dgViewDeduction.Name = "dgViewDeduction";
            this.dgViewDeduction.Size = new System.Drawing.Size(244, 333);
            this.dgViewDeduction.TabIndex = 36;
            // 
            // btnAddDeduction
            // 
            this.btnAddDeduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDeduction.Image = ((System.Drawing.Image)(resources.GetObject("btnAddDeduction.Image")));
            this.btnAddDeduction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddDeduction.Location = new System.Drawing.Point(6, 9);
            this.btnAddDeduction.Name = "btnAddDeduction";
            this.btnAddDeduction.Size = new System.Drawing.Size(175, 26);
            this.btnAddDeduction.TabIndex = 34;
            this.btnAddDeduction.Text = "Add Deduction";
            this.btnAddDeduction.UseVisualStyleBackColor = true;
            this.btnAddDeduction.Click += new System.EventHandler(this.btnAddDeduction_Click);
            // 
            // txtNetPay
            // 
            this.txtNetPay.Enabled = false;
            this.txtNetPay.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetPay.ForeColor = System.Drawing.Color.Red;
            this.txtNetPay.Location = new System.Drawing.Point(87, 375);
            this.txtNetPay.Multiline = true;
            this.txtNetPay.Name = "txtNetPay";
            this.txtNetPay.Size = new System.Drawing.Size(164, 26);
            this.txtNetPay.TabIndex = 32;
            this.txtNetPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 30;
            this.label3.Text = "Net Pay:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox5);
            this.groupBox5.Location = new System.Drawing.Point(662, 103);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(257, 40);
            this.groupBox5.TabIndex = 35;
            this.groupBox5.TabStop = false;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(6, 14);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(238, 20);
            this.textBox5.TabIndex = 32;
            this.textBox5.Text = "Employer Contribution";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dgViewEmployerContribution);
            this.groupBox6.Controls.Add(this.btnAddContribution);
            this.groupBox6.Location = new System.Drawing.Point(662, 142);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(257, 411);
            this.groupBox6.TabIndex = 36;
            this.groupBox6.TabStop = false;
            // 
            // dgViewEmployerContribution
            // 
            this.dgViewEmployerContribution.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewEmployerContribution.Location = new System.Drawing.Point(7, 38);
            this.dgViewEmployerContribution.Name = "dgViewEmployerContribution";
            this.dgViewEmployerContribution.Size = new System.Drawing.Size(244, 333);
            this.dgViewEmployerContribution.TabIndex = 33;
            // 
            // btnAddContribution
            // 
            this.btnAddContribution.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddContribution.Image = ((System.Drawing.Image)(resources.GetObject("btnAddContribution.Image")));
            this.btnAddContribution.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddContribution.Location = new System.Drawing.Point(6, 9);
            this.btnAddContribution.Name = "btnAddContribution";
            this.btnAddContribution.Size = new System.Drawing.Size(175, 26);
            this.btnAddContribution.TabIndex = 35;
            this.btnAddContribution.Text = "Add Contribution";
            this.btnAddContribution.UseVisualStyleBackColor = true;
            this.btnAddContribution.Click += new System.EventHandler(this.btnAddContribution_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button3);
            this.groupBox7.Controls.Add(this.button2);
            this.groupBox7.Location = new System.Drawing.Point(3, 552);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(916, 40);
            this.groupBox7.TabIndex = 37;
            this.groupBox7.TabStop = false;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(454, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 26);
            this.button3.TabIndex = 36;
            this.button3.Text = "Print Payroll";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(272, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 26);
            this.button2.TabIndex = 35;
            this.button2.Text = "Save Payroll";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmPayroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 594);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpData);
            this.Controls.Add(this.txtDeductID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtDeduction);
            this.Name = "frmPayroll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payroll Generator";
            this.Load += new System.EventHandler(this.frmPayroll_Load);
            this.grpData.ResumeLayout(false);
            this.grpData.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewDeduction)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgViewEmployerContribution)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpData;
        public System.Windows.Forms.TextBox txtDeductID;
        public System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.TextBox txtDeduction;
        public System.Windows.Forms.ComboBox cmbPayFrequency;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.TextBox txtNetPay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        public System.Windows.Forms.TextBox txtGrossPay;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtNoOfDaysCompute;
        public System.Windows.Forms.TextBox txtNoOfDays;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtRegularOTCompute;
        public System.Windows.Forms.TextBox txtRegularOT;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtLegalHolidayCompute;
        public System.Windows.Forms.TextBox txtLegalHoliday;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtSpecialHolidayCompute;
        public System.Windows.Forms.TextBox txtSpecialHoliday;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgViewEmployerContribution;
        private System.Windows.Forms.Button btnAddDeduction;
        private System.Windows.Forms.DataGridView dgViewDeduction;
        private System.Windows.Forms.Button btnAddContribution;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Button btnSaveSalary;
    }
}