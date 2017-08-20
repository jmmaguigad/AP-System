namespace Attendance
{
    partial class Form2
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.ePinoyAttendanceSheetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetAttendance = new Attendance.DataSetAttendance();
            this.btnPrintAttendance = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtSearchEmp = new System.Windows.Forms.TextBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.ePinoyAttendanceSheetTableAdapter = new Attendance.DataSetAttendanceTableAdapters.ePinoyAttendanceSheetTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ePinoyAttendanceSheetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // ePinoyAttendanceSheetBindingSource
            // 
            this.ePinoyAttendanceSheetBindingSource.DataMember = "ePinoyAttendanceSheet";
            this.ePinoyAttendanceSheetBindingSource.DataSource = this.DataSetAttendance;
            // 
            // DataSetAttendance
            // 
            this.DataSetAttendance.DataSetName = "DataSetAttendance";
            this.DataSetAttendance.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnPrintAttendance
            // 
            this.btnPrintAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintAttendance.Location = new System.Drawing.Point(560, 13);
            this.btnPrintAttendance.Name = "btnPrintAttendance";
            this.btnPrintAttendance.Size = new System.Drawing.Size(178, 24);
            this.btnPrintAttendance.TabIndex = 1;
            this.btnPrintAttendance.Text = "Print Attendance";
            this.btnPrintAttendance.UseVisualStyleBackColor = true;
            this.btnPrintAttendance.Click += new System.EventHandler(this.btnPrintAttendance_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource2.Name = "ePinoyAttendanceReportDS";
            reportDataSource2.Value = this.ePinoyAttendanceSheetBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Attendance.attendanceReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 50);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(742, 469);
            this.reportViewer1.TabIndex = 2;
            // 
            // txtSearchEmp
            // 
            this.txtSearchEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchEmp.Location = new System.Drawing.Point(262, 13);
            this.txtSearchEmp.Multiline = true;
            this.txtSearchEmp.Name = "txtSearchEmp";
            this.txtSearchEmp.Size = new System.Drawing.Size(292, 24);
            this.txtSearchEmp.TabIndex = 3;
            this.txtSearchEmp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbMonth
            // 
            this.cmbMonth.DropDownHeight = 200;
            this.cmbMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.IntegralHeight = false;
            this.cmbMonth.Location = new System.Drawing.Point(5, 13);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(251, 24);
            this.cmbMonth.TabIndex = 4;
            this.cmbMonth.SelectedIndexChanged += new System.EventHandler(this.cmbMonth_SelectedIndexChanged);
            // 
            // ePinoyAttendanceSheetTableAdapter
            // 
            this.ePinoyAttendanceSheetTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 519);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.txtSearchEmp);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnPrintAttendance);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Viewer";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ePinoyAttendanceSheetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetAttendance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPrintAttendance;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ePinoyAttendanceSheetBindingSource;
        private DataSetAttendance DataSetAttendance;
        private DataSetAttendanceTableAdapters.ePinoyAttendanceSheetTableAdapter ePinoyAttendanceSheetTableAdapter;
        private System.Windows.Forms.TextBox txtSearchEmp;
        private System.Windows.Forms.ComboBox cmbMonth;
    }
}