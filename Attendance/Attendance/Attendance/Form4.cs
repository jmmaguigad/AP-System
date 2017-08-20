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
    public partial class frmEmployeeDeduction : Form
    {
        public string connectionString = "server=68.235.33.254;database=jologs_hrmnew;uid=jologs_hrmnew;pwd=cYtology28;port=3306;convert zero datetime=True";
        public frmEmployeeDeduction()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var frmShw3 = new frmAddDeduction();
            frmShw3.Text = "Add Employee Deduction";
            frmShw3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var frmShw5 = new Form5();   
            frmShw5.Text = "Search Employee for Deduction";
            frmShw5.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frmShw5 = new Form5();
            frmShw5.Text = "Search Deduction of Employee";
            frmShw5.Show();
        }

        private void frmEmployeeDeduction_Load(object sender, EventArgs e)
        {
            LoadDeductionsCmb();
        }

        public void LoadDeductionsCmb()
        {
            MySqlConnection cnn = new MySqlConnection(connectionString);
            DataSet ds = new DataSet();
            string getDeductionSQL = "SELECT * FROM epdeduction ORDER BY id";
            MySqlDataAdapter sda = new MySqlDataAdapter(getDeductionSQL, cnn);

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

            cmbDeduction.DataSource = ds.Tables[0];
            cmbDeduction.DisplayMember = ds.Tables[0].Columns[1].ToString();
        }

        private void cmbDeduction_SelectedIndexChanged(object sender, EventArgs e)
        {
            int currentMyComboBoxIndex = cmbDeduction.SelectedIndex + 1;
            txtDeductID.Text = currentMyComboBoxIndex.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var frmShw3 = new frmAddDeduction();
            frmShw3.Text = "Add Deduction of Employee";
            frmShw3.Show();
        }

        public void LoadIndividualEmployeeDeduction()
        {
            MySqlConnection cnn;
            cnn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT epsalarydeduction.employee, epsalarydeduction.deduction, epdeduction.deduction_name, epsalarydeduction.amount FROM epsalarydeduction INNER JOIN employees ON epsalarydeduction.employee = employees.id INNER JOIN epdeduction ON epsalarydeduction.deduction = epdeduction.id WHERE employees.id LIKE @empid", cnn);            
            cmd.Parameters.AddWithValue("@empid", txtID.Text);

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
                dgViewDeductionEmp.DataSource = bdsour;
                sda.Update(dta);
                dgViewDeductionEmp.Columns[2].HeaderCell.Value = "Deduction";
                dgViewDeductionEmp.Columns[3].HeaderCell.Value = "Amount";
                dgViewDeductionEmp.Columns[0].Visible = false;
                dgViewDeductionEmp.Columns[1].Visible = false;
                dgViewDeductionEmp.Columns[2].Width = 300;
                dgViewDeductionEmp.Columns[3].Width = 150;

                cnn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frmShw4 = new frmEmployeeDeduction();
            if (txtName.Text == "" || txtAmount.Text == "")
            {
                //MessageBox.Show("Blank Field Detected!");
            }
            else
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
                                string qryInsert = "INSERT INTO epsalarydeduction (employee,deduction,amount) VALUES (@txtempid,@txtdedid,@amount)";
                                MySqlCommand cmdInsert = new MySqlCommand(qryInsert, cnInsert);
                                cmdInsert.Parameters.AddWithValue("@txtempid", txtID.Text);
                                cmdInsert.Parameters.AddWithValue("@txtdedid", txtDeductID.Text);
                                cmdInsert.Parameters.AddWithValue("@amount", txtAmount.Text);
                                cnInsert.Open();
                                try
                                {
                                    if (cmdInsert.ExecuteNonQuery() == 1)
                                    {
                                        LoadIndividualEmployeeDeduction();
                                        cmbDeduction.Focus();
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
            }
        }
    }
}
