namespace Attendance
{
    partial class frmEmployeeDeduction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeDeduction));
            this.grpData = new System.Windows.Forms.GroupBox();
            this.cmbDeduction = new System.Windows.Forms.ComboBox();
            this.txtDeductID = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDeduction = new System.Windows.Forms.TextBox();
            this.dgViewDeductionEmp = new System.Windows.Forms.DataGridView();
            this.grpData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewDeductionEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // grpData
            // 
            this.grpData.Controls.Add(this.cmbDeduction);
            this.grpData.Controls.Add(this.txtDeductID);
            this.grpData.Controls.Add(this.txtID);
            this.grpData.Controls.Add(this.button3);
            this.grpData.Controls.Add(this.button4);
            this.grpData.Controls.Add(this.button5);
            this.grpData.Controls.Add(this.label3);
            this.grpData.Controls.Add(this.txtAmount);
            this.grpData.Controls.Add(this.button1);
            this.grpData.Controls.Add(this.label2);
            this.grpData.Controls.Add(this.label1);
            this.grpData.Controls.Add(this.txtName);
            this.grpData.Controls.Add(this.txtDeduction);
            this.grpData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpData.Location = new System.Drawing.Point(0, 0);
            this.grpData.Name = "grpData";
            this.grpData.Size = new System.Drawing.Size(535, 150);
            this.grpData.TabIndex = 5;
            this.grpData.TabStop = false;
            // 
            // cmbDeduction
            // 
            this.cmbDeduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDeduction.FormattingEnabled = true;
            this.cmbDeduction.Location = new System.Drawing.Point(125, 50);
            this.cmbDeduction.Name = "cmbDeduction";
            this.cmbDeduction.Size = new System.Drawing.Size(294, 24);
            this.cmbDeduction.TabIndex = 29;
            this.cmbDeduction.SelectedIndexChanged += new System.EventHandler(this.cmbDeduction_SelectedIndexChanged);
            // 
            // txtDeductID
            // 
            this.txtDeductID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.txtDeductID.ForeColor = System.Drawing.Color.Red;
            this.txtDeductID.Location = new System.Drawing.Point(549, 113);
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
            this.txtID.Location = new System.Drawing.Point(549, 85);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(89, 22);
            this.txtID.TabIndex = 27;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtID.Visible = false;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(425, 50);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 24);
            this.button3.TabIndex = 26;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(479, 15);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(48, 26);
            this.button4.TabIndex = 24;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(425, 15);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(48, 26);
            this.button5.TabIndex = 23;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Amount:";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.ForeColor = System.Drawing.Color.Red;
            this.txtAmount.Location = new System.Drawing.Point(125, 82);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(192, 25);
            this.txtAmount.TabIndex = 19;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(125, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 25);
            this.button1.TabIndex = 18;
            this.button1.Text = "Save Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Deduction:";
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
            this.txtName.Size = new System.Drawing.Size(294, 26);
            this.txtName.TabIndex = 14;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDeduction
            // 
            this.txtDeduction.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.txtDeduction.ForeColor = System.Drawing.Color.Red;
            this.txtDeduction.Location = new System.Drawing.Point(549, 60);
            this.txtDeduction.Multiline = true;
            this.txtDeduction.Name = "txtDeduction";
            this.txtDeduction.Size = new System.Drawing.Size(78, 19);
            this.txtDeduction.TabIndex = 12;
            this.txtDeduction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDeduction.Visible = false;
            // 
            // dgViewDeductionEmp
            // 
            this.dgViewDeductionEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewDeductionEmp.Location = new System.Drawing.Point(0, 150);
            this.dgViewDeductionEmp.Name = "dgViewDeductionEmp";
            this.dgViewDeductionEmp.Size = new System.Drawing.Size(535, 234);
            this.dgViewDeductionEmp.TabIndex = 4;
            // 
            // frmEmployeeDeduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 385);
            this.Controls.Add(this.grpData);
            this.Controls.Add(this.dgViewDeductionEmp);
            this.Name = "frmEmployeeDeduction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Deduction";
            this.Load += new System.EventHandler(this.frmEmployeeDeduction_Load);
            this.grpData.ResumeLayout(false);
            this.grpData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewDeductionEmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpData;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgViewDeductionEmp;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.TextBox txtDeduction;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.TextBox txtDeductID;
        public System.Windows.Forms.ComboBox cmbDeduction;
    }
}