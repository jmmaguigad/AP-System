using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;

namespace Attendance
{
    public partial class Form2 : Form
    {
        //public string connectionString = "server=68.235.33.254;database=jologs_hrmnew;uid=jologs_hrmnew;pwd=cYtology28;port=3306;convert zero datetime=True";
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 12; i++)
            {
                cmbMonth.Items.Add(new DateTime(DateTime.Now.Year, i, 1).ToString("MMMM"));
            }
            cmbMonth.SelectedText = DateTime.Now.ToString("MMMM");
            cmbMonth.Focus();
        }


        private void GetDataSet()
        {

        }

        private void txtAttendanceCode_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void btnPrintAttendance_Click(object sender, EventArgs e)
        {
            try
            {
                int indexMonth = cmbMonth.Items.IndexOf(cmbMonth.Text) + 1;
                var iString = indexMonth.ToString();
                if (iString.Length == 1)
                {
                    iString = iString.PadLeft(2, '0');
                }
                //MessageBox.Show(iString);
                // TODO: This line of code loads data into the 'DataSetAttendance.ePinoyAttendanceSheet' table. You can move, or remove it, as needed.
                //this.ePinoyAttendanceSheetTableAdapter.Fill(this.DataSetAttendance.ePinoyAttendanceSheet);
                this.ePinoyAttendanceSheetTableAdapter.Fill(this.DataSetAttendance.ePinoyAttendanceSheet, txtSearchEmp.Text, txtSearchEmp.Text, iString);
                //DataSet ds = new DataSet();
                //ds.ReadXml("Data.xml");
                //ePinoyAttendanceSheetBindingSource.DataSource = ds;
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
