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
    public partial class frmAddDeduction : Form
    {
        public string connectionString = "server=68.235.33.254;database=jologs_hrmnew;uid=jologs_hrmnew;pwd=cYtology28;port=3306;convert zero datetime=True";
        public frmAddDeduction()
        {
            InitializeComponent();
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
                dgViewDeduction.DataSource = bdsour;
                sda.Update(dta);
                dgViewDeduction.Columns[0].Visible = false;
                dgViewDeduction.Columns[1].HeaderCell.Value = "Deduction";
                dgViewDeduction.Columns[1].Width = 300;

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
            if (txtDeduction.Text == "")
            {
                MessageBox.Show("Blank Field Detected!");
                txtDeduction.Focus();
            } 
            else
            {
                using (MySqlConnection cnInsert = new MySqlConnection(connectionString))
                {
                    try
                    {
                        string qryInsert = "INSERT INTO epdeduction (deduction_name) VALUES (@txtdeduction)";
                        MySqlCommand cmdInsert = new MySqlCommand(qryInsert, cnInsert);
                        cmdInsert.Parameters.AddWithValue("@txtdeduction", txtDeduction.Text);
                        cnInsert.Open();
                        try
                        {
                            if (cmdInsert.ExecuteNonQuery() == 1)
                            {
                                if (this.Text == "Add Employee Deduction")
                                {
                                    this.Close();
                                    frmShw4.Show();
                                }
                                else if (this.Text == "Add Deduction of Employee")
                                {
                                    frmShw4.LoadDeductionsCmb();
                                    this.Close();
                                }
                                else
                                {
                                    LoadDeductions();
                                    txtDeduction.Text = "";
                                    txtDeduction.Focus();
                                }
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

        private void frmAddDeduction_Load(object sender, EventArgs e)
        {
            LoadDeductions();
            txtDeduction.Focus();
        }
    }
}
