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
    public partial class Form5 : Form
    {
        public string connectionString = "server=68.235.33.254;database=jologs_hrmnew;uid=jologs_hrmnew;pwd=cYtology28;port=3306;convert zero datetime=True";
        public Form5()
        {
            InitializeComponent();
        }

        private void LoadEmployees()
        {
            MySqlConnection cnn;
            cnn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT id as No,employee_id as ID_No, CONCAT(first_name,' ',last_name) AS wholename FROM employees WHERE employee_id != 'EMP001' AND employee_id != 'EMP00999'", cnn);

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
                dgViewSearch.DataSource = bdsour;
                sda.Update(dta);
                dgViewSearch.Columns[1].HeaderCell.Value="Employee No";
                dgViewSearch.Columns[2].HeaderCell.Value = "Employee Name";
                dgViewSearch.Columns[0].Visible = false;
                dgViewSearch.Columns[2].Width = 300;

                cnn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadIndividualEmployee()
        {
            MySqlConnection cnn;
            cnn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT id as No,employee_id as ID_No, CONCAT(first_name,' ',last_name) AS wholename,first_name,last_name FROM employees WHERE employee_id != 'EMP001' AND employee_id != 'EMP00999' AND (first_name LIKE @searchKeyword OR last_name LIKE @searchKeyword)", cnn);
            cmd.Parameters.AddWithValue("@searchKeyword", txtSearch.Text);

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
                dgViewSearch.DataSource = bdsour;
                sda.Update(dta);
                dgViewSearch.Columns[1].HeaderCell.Value = "Employee No";
                dgViewSearch.Columns[2].HeaderCell.Value = "Employee Name";
                dgViewSearch.Columns[0].Visible = false;
                dgViewSearch.Columns[2].Width = 300;
                dgViewSearch.Columns[3].Visible = false;
                dgViewSearch.Columns[4].Visible = false;

                cnn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadDeductions()
        {
            MySqlConnection cnn;
            cnn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM epdeduction ORDER BY deduction_name", cnn);

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
                dgViewSearch.DataSource = bdsour;
                sda.Update(dta);
                dgViewSearch.Columns[0].Visible = false;
                dgViewSearch.Columns[1].HeaderCell.Value = "Deduction";
                dgViewSearch.Columns[1].Width = 300;

                cnn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            if (this.Text == "Search Employee for Deduction" || this.Text == "Search Employee for Attendance")
            {
                LoadEmployees();
            }
            else if (this.Text == "Search Form")
            {
                LoadEmployees();
            }
            else if (this.Text == "Search Deduction of Employee")
            {
                LoadDeductions();
            }        
            else
            {
                LoadIndividualEmployee();
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (this.Text == "Search Employee for Deduction")
            {
                LoadEmployees();
            }
            else
            {
                LoadIndividualEmployee();
            }
        }

        private void dgViewSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (this.Text == "Search Employee for Attendance")
                {
                    var frmShw6 = new frmAddEmployeeAttendance();
                    DataGridViewRow row = this.dgViewSearch.Rows[e.RowIndex];
                    string emp_name = row.Cells[2].Value.ToString();
                    string emp_id = row.Cells[0].Value.ToString();
                    frmShw6.txtName.Text = emp_name;
                    frmShw6.txtID.Text = emp_id;
                    frmShw6.Text = "Load Employee Attendance";
                    frmShw6.Show();
                    this.Close();
                }
                else if (this.Text == "Search Employee for Deduction")
                {
                    var frmShw4 = new frmEmployeeDeduction();
                    DataGridViewRow row = this.dgViewSearch.Rows[e.RowIndex];
                    string emp_name = row.Cells[2].Value.ToString();
                    string emp_id = row.Cells[0].Value.ToString();
                    frmShw4.txtName.Text = emp_name;
                    frmShw4.txtID.Text = emp_id;
                    frmShw4.LoadIndividualEmployeeDeduction();
                    frmShw4.Show();
                    frmShw4.cmbDeduction.Focus();
                    this.Close();
                }
                else
                {
                    var frmShw4 = new frmEmployeeDeduction();
                    DataGridViewRow row = this.dgViewSearch.Rows[e.RowIndex];
                    string ded_name = row.Cells[1].Value.ToString();
                    string ded_id = row.Cells[0].Value.ToString();
                    frmShw4.txtDeductID.Text = ded_id;
                    frmShw4.txtDeduction.Text = ded_name;
                    frmShw4.Show();
                    this.Close();
                }
            }
        }

        private void dgViewSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
