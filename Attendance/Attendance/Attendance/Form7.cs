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
    public partial class frmAttendanceSummary : Form
    {
        public string connectionString = "server=68.235.33.254;database=jologs_hrmnew;uid=jologs_hrmnew;pwd=cYtology28;port=3306;convert zero datetime=True";
        public frmAttendanceSummary()
        {
            InitializeComponent();
        }

        private void frmFetchAttendance_Load(object sender, EventArgs e)
        {
            LoadEmployeesCmb();
            LoadAttendanceList();
            cmbEmployee.SelectedIndex = -1;
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
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cnn.Close();
            }
        }

        private void cmdGenerate_Click(object sender, EventArgs e)
        {
            //dapat employee name at sahod lang magpapakita
            FetchAttendance();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if ((dTP1.Text != "" && dTP2.Text != "") && cmbEmployee.Text != "")
            {
                this.Text = "Filter Attendance";
                LoadIndividualAttendanceList();
            } 
        }

        public void LoadAttendanceList()
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    MySqlCommand selectEmployee = new MySqlCommand("SELECT CONCAT(employees.first_name, ' ', employees.last_name) AS whole_name, employees.employee_id, employees.id, attendanceepinoy.id, attendanceepinoy.employee, attendanceepinoy.in_time_am, attendanceepinoy.out_time_am, attendanceepinoy.in_time_pm, attendanceepinoy.out_time_pm, attendanceepinoy.attendanceimpression, ROUND((TIMESTAMPDIFF(MINUTE,attendanceepinoy.in_time_am,attendanceepinoy.out_time_am)/60),2) as timedifferenceAM, ROUND((TIMESTAMPDIFF(MINUTE,attendanceepinoy.in_time_pm,attendanceepinoy.out_time_pm)/60),2) as timedifferencePM FROM attendanceepinoy INNER JOIN employees ON attendanceepinoy.employee = employees.id WHERE ((DATE(in_time_am) >= @date1 AND DATE(in_time_am) <= @date2) OR (DATE(in_time_pm) >= @date1 AND DATE(in_time_pm) <= @date2)) OR (attendanceepinoy.employee != 1 AND attendanceepinoy.employee != 3)", con);
                    selectEmployee.Parameters.AddWithValue("@date1", dTP1.Text);
                    selectEmployee.Parameters.AddWithValue("@date2", dTP2.Text);
                    try
                    {
                        MySqlDataAdapter mSDA = new MySqlDataAdapter();
                        mSDA.SelectCommand = selectEmployee;
                        DataTable dt = new DataTable();
                        mSDA.Fill(dt);
                        BindingSource bdsource = new BindingSource();
                        bdsource.DataSource = dt;
                        dgView.DataSource = bdsource;
                        mSDA.Update(dt);                        
                        dgView.Columns[0].HeaderText = "Employee";
                        dgView.Columns[0].Width = 170;
                        for (int i = 1; i <= 4; i++)
                        {
                            dgView.Columns[i].Visible = false;
                        }
                        for (int i = 5; i <= 8; i++)
                        {
                            dgView.Columns[i].Width = 150;
                        }                        
                        dgView.Columns[5].HeaderText = "Time In AM";
                        dgView.Columns[6].HeaderText = "Time Out AM";
                        dgView.Columns[7].HeaderText = "Time In PM";
                        dgView.Columns[8].HeaderText = "Time Out PM";
                        dgView.Columns[9].Visible = false;
                        foreach (DataGridViewRow row in dgView.Rows)
                        {
                            if (Convert.ToString(row.Cells[9].Value) == "Complete")
                            {
                                row.DefaultCellStyle.BackColor = Color.SkyBlue;
                            } else
                            {
                                row.DefaultCellStyle.BackColor = Color.Red;
                            }
                            if (row.Cells[10].Value == null || row.Cells[10].Value == DBNull.Value || String.IsNullOrWhiteSpace(row.Cells[10].Value.ToString())) {
                                row.Cells[10].Value = 0;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        public void LoadIndividualAttendanceList()
        {
            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                try
                {                   
                    MySqlCommand selectEmployee = new MySqlCommand("SELECT CONCAT(employees.first_name, ' ', employees.last_name) AS whole_name, employees.employee_id, employees.id, attendanceepinoy.id, attendanceepinoy.employee, attendanceepinoy.in_time_am, attendanceepinoy.out_time_am, attendanceepinoy.in_time_pm, attendanceepinoy.out_time_pm, attendanceepinoy.attendanceimpression,ROUND((TIMESTAMPDIFF(MINUTE,attendanceepinoy.in_time_am,attendanceepinoy.out_time_am)/60),2) as timedifferenceAM, ROUND((TIMESTAMPDIFF(MINUTE,attendanceepinoy.in_time_pm,attendanceepinoy.out_time_pm)/60),2) as timedifferencePM FROM attendanceepinoy INNER JOIN employees ON attendanceepinoy.employee = employees.id WHERE ((DATE(in_time_am) >= @date1 AND DATE(in_time_am) <= @date2) OR (DATE(in_time_pm) >= @date1 AND DATE(in_time_pm) <= @date2)) AND (attendanceepinoy.employee = @empid)", cnn);
                    //MySqlCommand selectEmployee = new MySqlCommand("SELECT CONCAT(employees.first_name, ' ', employees.last_name) AS whole_name,id, employee, in_time_am, out_time_am, in_time_pm, out_time_pm, ROUND(SUM((TIMESTAMPDIFF(MINUTE,in_time_am,out_time_pm)/60),(TIMESTAMPDIFF(MINUTE,in_time_pm,out_time_pm)/60)),2) as timedifference FROM attendanceepinoy WHERE ((DATE(in_time_am) >= @date1 AND DATE(in_time_am) <= @date2) OR (DATE(in_time_pm) >= @date1 AND DATE(in_time_pm) <= @date2)) AND employee = @empid", cnn); MySqlCommand selectEmployee = new MySqlCommand("SELECT CONCAT(employees.first_name, ' ', employees.last_name) AS whole_name,id, employee, in_time_am, out_time_am, in_time_pm, out_time_pm, ROUND(TIMESTAMPDIFF(MINUTE,in_time_am,out_time_pm)/60,2) as timedifference FROM attendanceepinoy WHERE ((DATE(in_time_am) >= @date1 AND DATE(in_time_am) <= @date2) OR (DATE(in_time_pm) >= @date1 AND DATE(in_time_pm) <= @date2)) AND employee = @empid", cnn);                    
                    selectEmployee.Parameters.AddWithValue("@date1", dTP1.Text);
                    selectEmployee.Parameters.AddWithValue("@date2", dTP2.Text);
                    selectEmployee.Parameters.AddWithValue("@empid", txtEmpID.Text);
                    try
                    {
                        MySqlDataAdapter mSDA = new MySqlDataAdapter();
                        mSDA.SelectCommand = selectEmployee;
                        DataTable dt = new DataTable();
                        mSDA.Fill(dt);
                        BindingSource bdsource = new BindingSource();
                        bdsource.DataSource = dt;
                        dgView.DataSource = bdsource;
                        mSDA.Update(dt);
                        dgView.Columns[0].HeaderText = "Employee";
                        dgView.Columns[0].Width = 170;
                        for (int i = 1; i <= 4; i++)
                        {
                            dgView.Columns[i].Visible = false;
                        }
                        for (int i = 5; i <= 8; i++)
                        {
                            dgView.Columns[i].Width = 150;
                        }
                        dgView.Columns[5].HeaderText = "Time In AM";
                        dgView.Columns[6].HeaderText = "Time Out AM";
                        dgView.Columns[7].HeaderText = "Time In PM";
                        dgView.Columns[8].HeaderText = "Time Out PM";
                        dgView.Columns[9].Visible = false;
                        foreach (DataGridViewRow row in dgView.Rows)
                        {
                            if (Convert.ToString(row.Cells[9].Value) == "Complete")
                            {
                                row.DefaultCellStyle.BackColor = Color.SkyBlue;
                            }
                            else
                            {
                                row.DefaultCellStyle.BackColor = Color.Red;
                            }
                            if (row.Cells[10].Value == null || row.Cells[10].Value == DBNull.Value || String.IsNullOrWhiteSpace(row.Cells[10].Value.ToString()))
                            {
                                row.Cells[10].Value = 0;
                            }
                            if (row.Cells[11].Value == null || row.Cells[11].Value == DBNull.Value || String.IsNullOrWhiteSpace(row.Cells[11].Value.ToString()))
                            {
                                row.Cells[11].Value = 0;
                            }
                        }
                        dgView.Columns[10].Visible = false;
                        dgView.Columns[11].Visible = false;                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    cnn.Close();
                }
            }
        }

        public void LoadEmployeesCmb()
        {           
            MySqlConnection cnn = new MySqlConnection(connectionString);
            DataSet ds = new DataSet();
            string getEmpSQL = "SELECT id, first_name FROM employees WHERE (id != 1 AND id != 3) ORDER BY id";
            MySqlDataAdapter sda = new MySqlDataAdapter(getEmpSQL, cnn);

            try
            {
                cnn.Open();
                sda.Fill(ds);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occured while connecting to database" + ex.ToString());
            }
            finally
            {
                cnn.Close();
            }

            cmbEmployee.DataSource = ds.Tables[0];
            cmbEmployee.DisplayMember = ds.Tables[0].Columns[1].ToString();
        }

        private void cmbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void addAttendanceDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var showFrm6 = new frmAddEmployeeAttendance();
            showFrm6.Show();
        }

        private void txtEmpID_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbEmployee_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            MySqlConnection cnn = new MySqlConnection(connectionString);
            DataSet ds = new DataSet();
            string getEmpSQL = "SELECT id, first_name FROM employees where first_name = @first_name";
            MySqlCommand mCmd = new MySqlCommand(getEmpSQL, cnn);
            mCmd.Parameters.AddWithValue("@first_name", cmbEmployee.Text);
            MySqlDataReader mDr;
            try
            {
                cnn.Open();
                mDr = mCmd.ExecuteReader();
                while (mDr.Read())
                {
                    txtEmpID.Text = mDr.GetString("id");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occured while connecting to database" + ex.ToString());
            }
            finally
            {
                cnn.Close();
            }
        }

        private void dgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cmbEmployee.Text == "")
            {
                if (e.RowIndex >= 0)
                {
                    var shwFrm6 = new frmAddEmployeeAttendance();
                    DataGridViewRow row = this.dgView.Rows[e.RowIndex];
                    string att_id = row.Cells[3].Value.ToString();
                    shwFrm6.txtName.Text = row.Cells[0].Value.ToString();
                    shwFrm6.txtID.Text = txtEmpID.Text;
                    shwFrm6.txtAttID.Text = att_id;
                    shwFrm6.Text = "Edit Attendance";
                    shwFrm6.Show();
                    this.Close();
                }
            } else
            {
                if (e.RowIndex >= 0)
                {
                    var shwFrm6 = new frmAddEmployeeAttendance();
                    DataGridViewRow row = this.dgView.Rows[e.RowIndex];
                    string att_id = row.Cells[3].Value.ToString(); //bug 2 fix
                    shwFrm6.txtName.Text = cmbEmployee.Text;
                    shwFrm6.txtID.Text = txtEmpID.Text;
                    shwFrm6.txtAttID.Text = att_id;
                    shwFrm6.Text = "Edit Attendance";
                    shwFrm6.Show();
                    this.Close();
                }
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                string strInsert = "UPDATE attendanceepinoy SET attendanceminutes = @attminutes WHERE id=@attid";
                MySqlCommand cmdCheckIncomplete = new MySqlCommand(strInsert, con);
                con.Open();
                try
                {
                    for (int i = 0; i < dgView.Rows.Count; i++)
                    {
                        decimal attminutes = Convert.ToDecimal(dgView.Rows[i].Cells[10].Value) + Convert.ToDecimal(dgView.Rows[i].Cells[11].Value);
                        if (attminutes > 8)
                        {
                            attminutes = 8;
                        }
                        cmdCheckIncomplete.Parameters.AddWithValue("@attminutes", attminutes);
                        cmdCheckIncomplete.Parameters.AddWithValue("@attid", dgView.Rows[i].Cells[3].Value.ToString());
                        cmdCheckIncomplete.ExecuteNonQuery();
                        cmdCheckIncomplete.Parameters.Clear();
                    }
                } catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                } finally
                {
                    con.Close();
                    const string message = "Computation of Minutes Done, Ready for Printing or Payroll Generation.";
                    const string caption = "Successful Computation of Minutes";

                    MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            this.Text = "Load Attendance";
            LoadAttendanceList();
            cmbEmployee.SelectedIndex = -1;
        }

        private void dgView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            /**if (this.dgView.Columns[e.ColumnIndex].Name == "in_time_am")
            {
                if (e.Value != null)
                {
                    // Check for the string "pink" in the cell.
                    string stringValue = e.Value.ToString();                    
                    if ((stringValue == ""))
                    {
                        e.CellStyle.BackColor = Color.Pink;
                    } else
                    {
                        e.CellStyle.BackColor = Color.Blue;
                    }
                }
            }**/            
        }

        private void createPayrollToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var shwFrm5 = new Form5();
            shwFrm5.Text = "Generate Payroll";
            shwFrm5.Show();
            this.Close();
        }
    }
}
