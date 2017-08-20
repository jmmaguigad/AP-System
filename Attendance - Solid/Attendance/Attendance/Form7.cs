using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Attendance
{
    public partial class frmFetchAttendance : Form
    {
        public string connectionString = "server=68.235.33.254;database=jologs_hrmnew;uid=jologs_hrmnew;pwd=cYtology28;port=3306;convert zero datetime=True";
        public frmFetchAttendance()
        {
            InitializeComponent();
        }

        private void frmFetchAttendance_Load(object sender, EventArgs e)
        {
        
        }

        public void FetchAttendance()
        {
            MySqlConnection cnn;
            cnn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT id, employee, in_time_am, out_time_am, in_time_pm, out_time_pm, ROUND(TIMESTAMPDIFF(MINUTE,in_time_am,out_time_pm)/60,2) as timedifference FROM attendanceepinoy WHERE (DATE(in_time_am) >= @date1 AND DATE(in_time_am) <= @date2)", cnn);
            cmd.Parameters.AddWithValue("@date1", dTP1.Text);
            cmd.Parameters.AddWithValue("@date2", dTP2.Text);

            try
            {
                //1st Connection for 1st DG View                                
                cnn.Open();
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dta = new DataTable();
                sda.Fill(dta);
                BindingSource bdsour = new BindingSource();

                bdsour.DataSource = dta;
                dgView.DataSource = bdsour;
                sda.Update(dta);
//                dgView.Columns[2].HeaderCell.Value = "Deduction";
//                dgView.Columns[3].HeaderCell.Value = "Amount";
                //dgView.Columns[0].Visible = false;
                //dgView.Columns[1].Visible = false;
                //dgView.Columns[6].Visible = false;
                //dgView.Columns[7].Visible = false;
                //dgView.Columns[2].Width = 200;
                //dgView.Columns[3].Width = 200;
                //dgView.Columns[4].Width = 200;
                //dgView.Columns[5].Width = 200;

                cnn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdGenerate_Click(object sender, EventArgs e)
        {
            //dapat employee name at sahod lang magpapakita
            FetchAttendance();
        }
    }
}
