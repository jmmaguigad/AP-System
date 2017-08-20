namespace Attendance
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.grpData = new System.Windows.Forms.GroupBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgViewSearch = new System.Windows.Forms.DataGridView();
            this.grpData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // grpData
            // 
            this.grpData.Controls.Add(this.btnFilter);
            this.grpData.Controls.Add(this.label1);
            this.grpData.Controls.Add(this.txtSearch);
            this.grpData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpData.Location = new System.Drawing.Point(0, -2);
            this.grpData.Name = "grpData";
            this.grpData.Size = new System.Drawing.Size(547, 62);
            this.grpData.TabIndex = 7;
            this.grpData.TabStop = false;
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnFilter.Image")));
            this.btnFilter.Location = new System.Drawing.Point(487, 20);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(48, 27);
            this.btnFilter.TabIndex = 24;
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Search Term:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Red;
            this.txtSearch.Location = new System.Drawing.Point(110, 20);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(371, 27);
            this.txtSearch.TabIndex = 14;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgViewSearch
            // 
            this.dgViewSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewSearch.Location = new System.Drawing.Point(0, 61);
            this.dgViewSearch.Name = "dgViewSearch";
            this.dgViewSearch.Size = new System.Drawing.Size(547, 233);
            this.dgViewSearch.TabIndex = 6;
            this.dgViewSearch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgViewSearch_CellClick);
            this.dgViewSearch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgViewSearch_CellContentClick);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 294);
            this.Controls.Add(this.grpData);
            this.Controls.Add(this.dgViewSearch);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Form";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.grpData.ResumeLayout(false);
            this.grpData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgViewSearch;
        private System.Windows.Forms.Button btnFilter;
    }
}