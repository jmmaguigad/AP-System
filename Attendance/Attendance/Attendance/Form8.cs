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
    public partial class frmPayroll : Form
    {
        public string connectionString = "server=68.235.33.254;database=jologs_hrmnew;uid=jologs_hrmnew;pwd=cYtology28;port=3306;convert zero datetime=True";
        public frmPayroll()
        {
            InitializeComponent();
        }

        private void frmPayroll_Load(object sender, EventArgs e)
        {
            DetectEmployeeSalary();
            LoadDeductions();
            LoadEmployerContributions();
            LoadPayFrequency();
            GetEmployeeAttendanceComputation();
        }

        private void LoadEmployeeDeduction()
        {

        }        

        private void DetectEmployeeSalary()
        {
            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                try
                { 
                    cnn.Open();
                    MySqlCommand detectCmd = new MySqlCommand("SELECT * FROM employeesalary WHERE employee=@empid", cnn);
                    detectCmd.Parameters.AddWithValue("@empid", txtID.Text);
                    MySqlDataReader mdrDetect = detectCmd.ExecuteReader();
                    if (mdrDetect.Read())
                    {
                        string emp_frequency = mdrDetect.IsDBNull(3) ? null : mdrDetect.GetString("pay_frequency");
                        string emp_amount = mdrDetect.GetString("amount");
                        string emp_rate = mdrDetect.GetString("rate");

                        cmbPayFrequency.Text = emp_frequency;
                        txtSalary.Text = emp_amount;
                        txtRate.Text = emp_rate;

                        if (cmbPayFrequency.Text == "" || txtSalary.Text == "0.00" || txtSalary.Text == "" || txtRate.Text == "0.00" || txtRate.Text == "")
                        {
                            string message = "Some Data were not found, please update employees salary frequency, salary amount and rate.";
                            string caption = "Needed Data were not found";

                            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                } catch (Exception ex)
                {
                    MessageBox.Show("Not successful to execute command due to: " + ex.Message);
                } finally
                {
                    cnn.Close();
                }
            }
        }

        private void GetEmployeeAttendanceComputation()
        {
            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                try
                {
                    cnn.Open();
                    MySqlCommand detectCmd = new MySqlCommand("SELECT SUM(attendanceminutes)/8 as daysworked,id FROM attendanceepinoy WHERE employee=@empid", cnn);
                    detectCmd.Parameters.AddWithValue("@empid", txtID.Text);
                    MySqlDataReader mdrDetect = detectCmd.ExecuteReader();
                    if (mdrDetect.Read())
                    {
                        decimal emp_amount = mdrDetect.GetDecimal("daysworked");
                        decimal rate;
                        //decimal noofdays;
                        decimal noofdayscompute;
                        rate = Convert.ToDecimal(txtRate.Text);
                        //noofdays = decimal.Parse(txtNoOfDays.Text);
                        //noofdayscompute = noofdays * rate;
                        noofdayscompute = emp_amount * rate;
                        txtNoOfDays.Text = emp_amount.ToString();
                        txtNoOfDaysCompute.Text = noofdayscompute.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Not successful to execute command due to: " + ex.Message);
                }
                finally
                {
                    cnn.Close();
                }
            }
        }

        private void LoadPayFrequency()
        {
            this.cmbPayFrequency.Items.Insert(0, "Hourly");
            this.cmbPayFrequency.Items.Insert(1, "Daily");
            this.cmbPayFrequency.Items.Insert(2, "Bi Weekly");
            this.cmbPayFrequency.Items.Insert(3, "Weekly");
            this.cmbPayFrequency.Items.Insert(4, "Semi Monthly");
            this.cmbPayFrequency.Items.Insert(4, "Monthly");            
        }

        private void LoadDeductions()
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                MySqlCommand cmdLoad = new MySqlCommand("SELECT * FROM epdeduction ORDER BY id", con);
                MySqlDataAdapter msaLoad = new MySqlDataAdapter();
                msaLoad.SelectCommand = cmdLoad;
                DataTable dtLoad = new DataTable();
                msaLoad.Fill(dtLoad);
                BindingSource bdsourceLoad = new BindingSource();
                bdsourceLoad.DataSource = dtLoad;
                dgViewDeduction.DataSource = bdsourceLoad;
                msaLoad.Update(dtLoad);

                dgViewDeduction.Columns[0].Visible = false;
                dgViewDeduction.Columns[1].HeaderText = "Deductions";
                dgViewDeduction.Columns[1].Width = 200;
            }
        }

        private void LoadEmployerContributions()
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                MySqlCommand cmdLoad = new MySqlCommand("SELECT * FROM employercontribution ORDER BY id", con);
                MySqlDataAdapter msaLoad = new MySqlDataAdapter();
                msaLoad.SelectCommand = cmdLoad;
                DataTable dtLoad = new DataTable();
                msaLoad.Fill(dtLoad);
                BindingSource bdsourceLoad = new BindingSource();
                bdsourceLoad.DataSource = dtLoad;
                dgViewEmployerContribution.DataSource = bdsourceLoad;
                msaLoad.Update(dtLoad);

                dgViewEmployerContribution.Columns[0].Visible = false;
                dgViewEmployerContribution.Columns[1].Visible = false;
                dgViewEmployerContribution.Columns[2].HeaderText = "Deductions";
                dgViewEmployerContribution.Columns[2].Width = 200;
                dgViewEmployerContribution.Columns[3].HeaderText = "Amount";
                dgViewEmployerContribution.Columns[3].Width = 200;
            }
        }

        private void txtRate_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddDeduction_Click(object sender, EventArgs e)
        {
            var frmShw4 = new frmEmployeeDeduction();
            frmShw4.Show();
        }

        private void btnAddContribution_Click(object sender, EventArgs e)
        {
            var frmShw9 = new frmAddEmployerContribution();
            frmShw9.Show();
        }

        private void btnSaveSalary_Click(object sender, EventArgs e)
        {
            if (cmbPayFrequency.Text == "" || txtSalary.Text == "" || txtRate.Text == "")
            {
                MessageBox.Show("Please check blank or incomplete fields!", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {                
                try
                {
                    MySqlConnection cnn = new MySqlConnection(connectionString);
                    cnn.Open();
                    MySqlCommand cmdSelect = new MySqlCommand("SELECT COUNT(*) FROM employeesalary WHERE employee=@empid", cnn);
                    cmdSelect.Parameters.AddWithValue("@empid", txtID.Text);
                    int userCount = Convert.ToInt32(cmdSelect.ExecuteScalar());
                    if (userCount > 0)
                    {
                        MySqlConnection con = new MySqlConnection(connectionString);
                        con.Open();
                        MySqlCommand cmdSelectEmp = new MySqlCommand("SELECT pay_frequency, amount, rate FROM employeesalary WHERE employee=@empid", con);
                        cmdSelectEmp.Parameters.AddWithValue("@empid", txtID.Text);
                        MySqlDataReader mdrSelect = cmdSelectEmp.ExecuteReader();
                        if (mdrSelect.Read())
                        {
                            string pay_frequency = mdrSelect.IsDBNull(0) ? null : mdrSelect.GetString(0);
                            string amount = mdrSelect.GetString(1);
                            string rate = mdrSelect.GetString(2);

                            if ((pay_frequency == "" || pay_frequency == null) || (amount == "0.00" || amount == "" || amount == null) || (rate == "0.00" || rate == "" || rate == null))
                            {
                                MySqlConnection cnupdate = new MySqlConnection(connectionString);
                                MySqlCommand cmdUpdate = new MySqlCommand("UPDATE employeesalary SET pay_frequency=@pay_frequency,amount=@amount,rate=@rate WHERE employee=@empid", cnupdate);
                                cnupdate.Open();
                                cmdUpdate.Parameters.AddWithValue("@pay_frequency", cmbPayFrequency.Text);
                                cmdUpdate.Parameters.AddWithValue("@amount", txtSalary.Text);
                                cmdUpdate.Parameters.AddWithValue("@rate", txtRate.Text);
                                cmdUpdate.Parameters.AddWithValue("@empid", txtID.Text);
                                if (cmdUpdate.ExecuteNonQuery() == 1)
                                {
                                    MessageBox.Show("Details were saved successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    txtNoOfDays.Focus();
                                }
                                cnupdate.Close();
                            }
                            else
                            {
                                var dialog = MessageBox.Show("This employee has saved employee salary details already. If employee has increase in salary, press Okey else cancel.", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                                if (dialog == DialogResult.Yes)
                                {
                                    MySqlConnection cnupdating = new MySqlConnection(connectionString);
                                    MySqlCommand cmdUpdate = new MySqlCommand("UPDATE employeesalary SET pay_frequency=@pay_frequency,amount=@amount,rate=@rate WHERE employee=@empid", cnupdating);
                                    cnupdating.Open();
                                    cmdUpdate.Parameters.AddWithValue("@pay_frequency", cmbPayFrequency.Text);
                                    cmdUpdate.Parameters.AddWithValue("@amount", txtSalary.Text);
                                    cmdUpdate.Parameters.AddWithValue("@rate", txtRate.Text);
                                    cmdUpdate.Parameters.AddWithValue("@empid", txtID.Text);
                                    if (cmdUpdate.ExecuteNonQuery() == 1)
                                    {
                                        MessageBox.Show("Details were saved successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        txtNoOfDays.Focus();
                                    }
                                    cnupdating.Close();
                                }
                            }
                        }
                        con.Close();
                    }
                    else
                    {
                        MySqlConnection cninsert = new MySqlConnection(connectionString);
                        MySqlCommand cmdInsert = new MySqlCommand("INSERT INTO employeesalary (employee,component,pay_frequency,amount,rate) VALUES (@empid,@component,@pay_frequency,@amount,@rate)", cninsert);
                        cninsert.Open();
                        cmdInsert.Parameters.AddWithValue("@empid", txtID.Text);
                        cmdInsert.Parameters.AddWithValue("@component", 1);
                        cmdInsert.Parameters.AddWithValue("@pay_frequency", cmbPayFrequency.Text);
                        cmdInsert.Parameters.AddWithValue("@amount", txtSalary.Text);
                        cmdInsert.Parameters.AddWithValue("@rate", txtRate.Text);
                        if (cmdInsert.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Details were saved successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtNoOfDays.Focus();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var shwFrm5 = new Form5();
            shwFrm5.Text = "Generate Payroll";
            shwFrm5.Show();
            this.Close();
        }
    }
}
