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
    public partial class frmAddEmployeeAttendance : Form
    {
        public string connectionString = "server=68.235.33.254;database=jologs_hrmnew;uid=jologs_hrmnew;pwd=cYtology28;port=3306;convert zero datetime=True";
        public frmAddEmployeeAttendance()
        {
            InitializeComponent();
        }

        private void frmAddEmployeeAttendance_Load(object sender, EventArgs e)
        {
            //dateTimePicker1.Format = DateTimePickerFormat.Custom;
            //dateTimePicker1.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            //dateTimePicker1.Text = "0000-00-00 00:00:00";
            if (this.Text == "Add Attendance")
            {
                LoadAttendance();
            }
            else if (this.Text == "Edit Attendance")
            {
                EditLoadAttendanceofEmployee();
            }
            else
            {
                LoadAttendanceofEmployee();
            }
        }

        private void EditLoadAttendanceofEmployee()
        {
            MySqlConnection cnn;
            cnn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT attendanceepinoy.id,attendanceepinoy.employee,attendanceepinoy.in_time_am, attendanceepinoy.out_time_am, attendanceepinoy.in_time_pm, attendanceepinoy.out_time_pm FROM attendanceepinoy WHERE id=@att_id", cnn);
            cmd.Parameters.AddWithValue("@att_id", txtAttID.Text);
            //2nd datagrid connection
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
                dgViewAttendance.DataSource = bdsour;
                sda.Update(dta);
                dgViewAttendance.Columns[0].Visible = false;
                dgViewAttendance.Columns[1].Visible = false;
                dgViewAttendance.Columns[2].HeaderCell.Value = "Time In AM";
                dgViewAttendance.Columns[2].Width = 110;
                dgViewAttendance.Columns[3].HeaderCell.Value = "Time Out AM";
                dgViewAttendance.Columns[3].Width = 110;
                dgViewAttendance.Columns[4].HeaderCell.Value = "Time In PM";
                dgViewAttendance.Columns[4].Width = 110;
                dgViewAttendance.Columns[5].HeaderCell.Value = "Time Out AM";
                dgViewAttendance.Columns[5].Width = 110;
                //dgViewAttendance.Columns[6].Visible = false;

                MySqlDataReader mDr;
                mDr = cmd.ExecuteReader();
                while (mDr.Read())
                {
                    maskedTextBox1.Text = mDr.GetDateTime("in_time_am").ToString("yyyy-MM-dd hh:mm:ss");
                    maskedTextBox2.Text = mDr.GetDateTime("out_time_am").ToString("yyyy-MM-dd hh:mm:ss");
                    maskedTextBox3.Text = mDr.GetDateTime("in_time_pm").ToString("yyyy-MM-dd hh:mm:ss");
                    maskedTextBox4.Text = mDr.GetDateTime("out_time_pm").ToString("yyyy-MM-dd hh:mm:ss");
                }

                cnn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadAttendance()
        {
            MySqlConnection cnn;
            cnn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT employees.employee_id, attendanceepinoy.employee, attendanceepinoy.in_time_am, attendanceepinoy.out_time_am, attendanceepinoy.in_time_pm, attendanceepinoy.out_time_pm, employees.id FROM attendanceepinoy INNER JOIN employees ON attendanceepinoy.employee = employees.id  ORDER BY DATE(attendanceepinoy.in_time_am)", cnn);

            //2nd datagrid connection
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
                dgViewAttendance.DataSource = bdsour;
                sda.Update(dta);
                //dgViewAttendance.Columns[0].HeaderCell.Value = "Employee";
                //dgViewAttendance.Columns[0].Width = 110;
                dgViewAttendance.Columns[0].Visible = false;
                dgViewAttendance.Columns[1].Visible = false;
                dgViewAttendance.Columns[2].HeaderCell.Value = "Time In AM";
                dgViewAttendance.Columns[2].Width = 110;
                dgViewAttendance.Columns[3].HeaderCell.Value = "Time Out AM";
                dgViewAttendance.Columns[3].Width = 110;
                dgViewAttendance.Columns[4].HeaderCell.Value = "Time In PM";
                dgViewAttendance.Columns[4].Width = 110;
                dgViewAttendance.Columns[5].HeaderCell.Value = "Time Out AM";
                dgViewAttendance.Columns[5].Width = 110;
                dgViewAttendance.Columns[6].Visible = false;

                cnn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LoadAttendanceofEmployee()
        {
            MySqlConnection cnn;
            cnn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT employees.employee_id, attendanceepinoy.employee, attendanceepinoy.in_time_am, attendanceepinoy.out_time_am, attendanceepinoy.in_time_pm, attendanceepinoy.out_time_pm, employees.id FROM attendanceepinoy INNER JOIN employees ON attendanceepinoy.employee = employees.id WHERE employees.id=@searchKeyword  ORDER BY DATE(attendanceepinoy.in_time_am)", cnn);
            cmd.Parameters.AddWithValue("@searchKeyword", txtID.Text);

            //2nd datagrid connection
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
                dgViewAttendance.DataSource = bdsour;
                sda.Update(dta);
                //dgViewAttendance.Columns[0].HeaderCell.Value = "Employee";
                //dgViewAttendance.Columns[0].Width = 110;
                dgViewAttendance.Columns[0].Visible = false;
                dgViewAttendance.Columns[1].Visible = false;
                dgViewAttendance.Columns[2].HeaderCell.Value = "Time In AM";
                dgViewAttendance.Columns[2].Width = 110;
                dgViewAttendance.Columns[3].HeaderCell.Value = "Time Out AM";
                dgViewAttendance.Columns[3].Width = 110;
                dgViewAttendance.Columns[4].HeaderCell.Value = "Time In PM";
                dgViewAttendance.Columns[4].Width = 110;
                dgViewAttendance.Columns[5].HeaderCell.Value = "Time Out AM";
                dgViewAttendance.Columns[5].Width = 110;
                dgViewAttendance.Columns[6].Visible = false;

                cnn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var frmShow5 = new Form5();
            frmShow5.Text = "Search Employee for Attendance";
            frmShow5.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "")
            {
                MessageBox.Show("Oops Null Value is not allowed!");
            }
            else
            {
                if (this.Text == "Add Attendance")
                {
                    try
                    {
                        using (MySqlConnection cnn = new MySqlConnection(connectionString))
                        {
                            cnn.Open();
                            using (MySqlConnection cnInsert = new MySqlConnection(connectionString))
                            {
                                try
                                {
                                    string sMonth = DateTime.Now.ToString("MM");
                                    string qryInsert = "INSERT INTO attendanceepinoy (employee,in_time_am,out_time_am,in_time_pm,out_time_pm,remark,monthnumber) VALUES (@txtid,@mskTxtBox1,@mskTxtBox2,@mskTxtBox3,@mskTxtBox4,@txtRemark,@sMonth)";
                                    //"('" + txtID.Text + "','" + maskedTextBox1.Text + "','" + maskedTextBox2.Text + "','" + maskedTextBox3.Text + "','" + maskedTextBox4.Text + "','" + txtRemark.Text + "','" + sMonth + "')";
                                    MySqlCommand cmdInsert = new MySqlCommand(qryInsert, cnInsert);
                                    cmdInsert.Parameters.AddWithValue("@txtid", txtID.Text);
                                    cmdInsert.Parameters.AddWithValue("@mskTxtBox1", maskedTextBox1.Text);
                                    cmdInsert.Parameters.AddWithValue("@mskTxtBox2", maskedTextBox2.Text);
                                    cmdInsert.Parameters.AddWithValue("@mskTxtBox3", maskedTextBox3.Text);
                                    cmdInsert.Parameters.AddWithValue("@mskTxtBox4", maskedTextBox4.Text);
                                    cmdInsert.Parameters.AddWithValue("@txtRemark", txtRemark.Text);
                                    cmdInsert.Parameters.AddWithValue("@sMonth", sMonth);
                                    cnInsert.Open();
                                    try
                                    {
                                        if (cmdInsert.ExecuteNonQuery() == 1)
                                        {
                                            LoadAttendanceofEmployee();
                                            maskedTextBox1.Text = "";
                                            maskedTextBox2.Text = "";
                                            maskedTextBox3.Text = "";
                                            maskedTextBox4.Text = "";
                                        }
                                        else
                                        {
                                            MessageBox.Show("Data Not Inserted");
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                    }
                                }
                                catch (MySqlException ex)
                                {
                                    MessageBox.Show("Error in adding record encountered: " + ex.Message);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                } else if (this.Text == "Edit Attendance")
                {
                    try
                    {
                        using (MySqlConnection cnn = new MySqlConnection(connectionString))
                        {
                            cnn.Open();
                            using (MySqlConnection cnUpdate = new MySqlConnection(connectionString))
                            {
                                try
                                {
                                    string qryUpdate = "UPDATE attendanceepinoy SET in_time_am = @mskTxtBox1, out_time_am = @mskTxtBox2, in_time_pm = @mskTxtBox3, out_time_pm = @mskTxtBox4 , remark = @remark WHERE id = @att_id";
                                    MySqlCommand cmdUpdate = new MySqlCommand(qryUpdate, cnUpdate);
                                    cmdUpdate.Parameters.AddWithValue("@att_id", txtAttID.Text);
                                    cmdUpdate.Parameters.AddWithValue("@mskTxtBox1", maskedTextBox1.Text);
                                    cmdUpdate.Parameters.AddWithValue("@mskTxtBox2", maskedTextBox2.Text);
                                    cmdUpdate.Parameters.AddWithValue("@mskTxtBox3", maskedTextBox3.Text);
                                    cmdUpdate.Parameters.AddWithValue("@mskTxtBox4", maskedTextBox4.Text);
                                    cmdUpdate.Parameters.AddWithValue("@remark", txtRemark.Text);
                                    cnUpdate.Open();
                                    try
                                    {
                                        if (cmdUpdate.ExecuteNonQuery() == 1)
                                        {
                                            var frmShw7 = new frmAttendanceSummary();
                                            frmShw7.LoadAttendanceList();
                                            frmShw7.Show();
                                            this.Close();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Data Not Updated");
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                    }
                                }
                                catch (MySqlException ex)
                                {
                                    MessageBox.Show("Error in adding record encountered: " + ex.Message);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
