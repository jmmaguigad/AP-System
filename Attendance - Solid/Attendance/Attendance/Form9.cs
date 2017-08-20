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
    public partial class frmAddEmployerContribution : Form
    {
        public string connectionString = "server=68.235.33.254;database=jologs_hrmnew;uid=jologs_hrmnew;pwd=cYtology28;port=3306;convert zero datetime=True";
        public frmAddEmployerContribution()
        {
            InitializeComponent();
        }

        private void frmAddEmployerContribution_Load(object sender, EventArgs e)
        {
            LoadDataContribution();
            txtContribution.Focus();
        }

        public void LoadDataContribution()
        {
            MySqlConnection cnn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM employercontribution ORDER BY id", cnn);

            MySqlConnection cnSelect = new MySqlConnection(connectionString);
            cnSelect.Open();
            MySqlCommand cmdSelect = new MySqlCommand("SELECT * FROM companystructures WHERE type LIKE 'company' LIMIT 1",cnSelect);
            MySqlDataReader mdr = cmdSelect.ExecuteReader();

            try
            {
                cnn.Open();
                MySqlDataAdapter mSDA = new MySqlDataAdapter();
                mSDA.SelectCommand = cmd;
                DataTable dta = new DataTable();
                mSDA.Fill(dta);

                BindingSource bdsource = new BindingSource();
                bdsource.DataSource = dta;
                dgView.DataSource = bdsource;

                dgView.Columns[0].Visible = false;
                dgView.Columns[1].Visible = false;
                dgView.Columns[2].Width = 300;
                dgView.Columns[3].Width = 300;
                dgView.Columns[2].HeaderText = "Employer Contribution";
                dgView.Columns[3].HeaderText = "Amount";

                if (mdr.Read())
                {
                    txtCompany.Text = mdr.GetInt32("id").ToString();
                }

                cnn.Close();

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtContribution.Text == "" || txtAmount.Text == "")
            {

            }
            else
            {
                using (MySqlConnection cnInsert = new MySqlConnection(connectionString))
                {
                    try
                    {
                        MySqlCommand cmdinsert = new MySqlCommand("INSERT INTO employercontribution (companyid,contribution_name,amount) VALUES (@companyid,@contribution_name,@amount)", cnInsert);
                        cmdinsert.Parameters.AddWithValue("@companyid", txtCompany.Text);
                        cmdinsert.Parameters.AddWithValue("@contribution_name", txtContribution.Text);
                        cmdinsert.Parameters.AddWithValue("@amount", txtAmount.Text);
                        cnInsert.Open();
                        try
                        {
                            if (cmdinsert.ExecuteNonQuery() == 1)
                            {
                                LoadDataContribution();
                                txtAmount.Clear();
                                txtContribution.Clear();
                                txtContribution.Focus();
                            } else
                            {
                                MessageBox.Show("Insert not successful!");
                            }
                        } catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    } catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
