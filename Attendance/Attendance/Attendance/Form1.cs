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
    public partial class frmAttendance : Form
    {
        Timer tPinoy = new Timer();
        int hhs = DateTime.Now.Hour;
        public string connectionString = "server=68.235.33.254;database=jologs_hrmnew;uid=jologs_hrmnew;pwd=cYtology28;port=3306;convert zero datetime=True";
        //public string connectionString = "server=localhost;database=icehrmdb;uid=icehrmdbuser;pwd=cYtology28;port=3306;convert zero datetime=True";
        public frmAttendance()
        {
            InitializeComponent();
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {

        }

        private void tPinoy_Tick(object sender,EventArgs e)
        {
            //get current time
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            //time
            string time = "";

            //padding leading zero
            if (hh < 10)
            {
                time += "0" + hh;
            } else
            {
                time += hh;
            }
            time += ":";

            if (mm < 10)
            {
                time += "0" + mm;
            } else
            {
                time += mm;
            }
            time += ":";

            if (ss < 10)
            {
                time += "0" + ss;
            } else
            {
                time += ss;
            }
            txtDate.Text = DateTime.UtcNow.Date.ToString("MM/dd/yyyy");
            txtTime.Text = time;
            txtDateTime.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            txtDetector.Text = hh.ToString();
        }

        private void TimeInAM_KeyDown(object sender,KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                button1_Click((object)sender,(EventArgs)e);               
            }
            else if (e.KeyCode == Keys.F2)
            {
                button2_Click((object)sender, (EventArgs)e);
            }
            else if (e.KeyCode == Keys.F3)
            {
                button3_Click((object)sender, (EventArgs)e);
            }
            else if (e.KeyCode==Keys.F4)
            {
                button4_Click((object)sender, (EventArgs)e);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //timer interval 
            tPinoy.Interval = 1000; //milliseconds
            tPinoy.Tick += new EventHandler(this.tPinoy_Tick);
            
            //start timer
            tPinoy.Start();

            //declare connection String variable
            //1st datagrid connection
            MySqlConnection cnn;            
            cnn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT id as No,employee_id as ID_No, CONCAT(first_name,' ',last_name) AS wholename FROM employees WHERE employee_id != 'EMP001' AND employee_id != 'EMP00999'", cnn);

            //2nd datagrid connection
            try
            {
                //2nd Connection for 2nd DG View
                dgView2Load();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgView2Load()
        {
            //2nd datagrid connection
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand cmd2 = new MySqlCommand("SELECT employees.employee_id, attendanceepinoy.employee, attendanceepinoy.in_time_am, attendanceepinoy.out_time_am, attendanceepinoy.in_time_pm, attendanceepinoy.out_time_pm, employees.id FROM attendanceepinoy INNER JOIN employees ON attendanceepinoy.employee = employees.id  WHERE DATE(attendanceepinoy.in_time_am)=CURDATE()", connection);
            try
            {
                //2nd Connection for 2nd DG View
                MySqlDataAdapter sda2 = new MySqlDataAdapter();
                sda2.SelectCommand = cmd2;
                DataTable dta2 = new DataTable();
                sda2.Fill(dta2);
                BindingSource bdsour2 = new BindingSource();

                bdsour2.DataSource = dta2;
                dgViewAttendance.DataSource = bdsour2;
                sda2.Update(dta2);
                dgViewAttendance.Columns[0].HeaderCell.Value = "Employee";
                dgViewAttendance.Columns[0].Width = 110;
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
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }

        private void dgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgView.Rows[e.RowIndex];
                string emp_name = row.Cells[2].Value.ToString();
                string emp_id = row.Cells[0].Value.ToString();
                txtName.Text = emp_name;
                txtID.Text = emp_id;
                TimeInAM.Text = "";
                TimeOutAM.Text = "";
                TimeInPM.Text = "";
                TimeOutPM.Text="";

                //get data from id extracted in dgView
                try
                {
                    MySqlConnection cnn;
                    cnn = new MySqlConnection(connectionString);
                    cnn.Open();
                    string selectQry = "SELECT in_time_am, out_time_am, in_time_pm, out_time_pm from attendanceepinoy  WHERE (DATE(in_time_am) LIKE CURDATE() OR DATE(in_time_pm) LIKE CURDATE()) AND employee LIKE '" + txtID.Text + "'";
                    MySqlCommand selectCmd = new MySqlCommand(selectQry, cnn);
                    MySqlDataReader mDr = selectCmd.ExecuteReader();

                    if (mDr.Read())
                    {
                        TimeInAM.Text = mDr.GetString("in_time_am");
                        TimeInAM.Select();
                        TimeOutAM.Text = mDr.GetString("out_time_am");
                        TimeInPM.Text = mDr.GetString("in_time_pm");
                        TimeOutPM.Text = mDr.GetString("out_time_pm");
                    }
                    cnn.Close();
                } catch (Exception)
                {

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCode.Text == "")
            {
                MessageBox.Show("Oops Null Value is not allowed!");
            }
            else
            {
                try
                {
                    using (MySqlConnection cnn = new MySqlConnection(connectionString))
                    {
                        MySqlCommand cmdchecker = new MySqlCommand("SELECT COUNT(*) FROM attendancecredentials WHERE att_code LIKE @codeid AND DATE(att_date) LIKE CURDATE()", cnn);
                        cmdchecker.Parameters.AddWithValue("@codeid", txtCode.Text);
                        cnn.Open();
                        int checkercnt = Convert.ToInt32(cmdchecker.ExecuteScalar());
                        if (checkercnt > 0)
                        {
                            //get data from id extracted in dgView
                            try
                            {
                                string selectQry = "SELECT employee from attendancecredentials WHERE att_code LIKE @codeid";
                                MySqlCommand selectCmd = new MySqlCommand(selectQry, cnn);
                                selectCmd.Parameters.AddWithValue("@codeid", txtCode.Text);
                                using (MySqlDataReader mDr = selectCmd.ExecuteReader())
                                {
                                    if (mDr.Read())
                                    {
                                        txtID.Text = mDr.GetString("employee");
                                        using (MySqlConnection cnn1 = new MySqlConnection(connectionString))
                                        {
                                            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM attendanceepinoy WHERE (DATE(in_time_am) LIKE CURDATE() OR DATE(in_time_pm) LIKE CURDATE()) AND employee LIKE @employeeid", cnn1);
                                            cmd.Parameters.AddWithValue("@employeeid", txtID.Text);
                                            cnn1.Open();
                                            int userCount = Convert.ToInt32(cmd.ExecuteScalar());
                                            if (userCount == 0)
                                            {
                                                using (MySqlConnection cnInsert = new MySqlConnection(connectionString))
                                                {
                                                    try
                                                    {
                                                        string sMonth = DateTime.Now.ToString("MM");
                                                        string qryInsert = "INSERT INTO attendanceepinoy (employee,in_time_am,monthnumber) VALUES ('" + txtID.Text + "','" + txtDateTime.Text + "','" + sMonth + "')"; 
                                                        MySqlCommand cmdInsert = new MySqlCommand(qryInsert, cnInsert);
                                                        cnInsert.Open();
                                                        try
                                                        {
                                                            if (cmdInsert.ExecuteNonQuery() == 1)
                                                            {
                                                                dgView2Load();
                                                                using (MySqlConnection cnn2 = new MySqlConnection(connectionString))
                                                                {
                                                                    MySqlCommand selectCmdEmp = new MySqlCommand("SELECT CONCAT(first_name,' ',last_name) as wholename,id from employees WHERE id LIKE @empid", cnn2);
                                                                    selectCmdEmp.Parameters.AddWithValue("@empid", txtID.Text);
                                                                    cnn2.Open();
                                                                    using (MySqlDataReader mDrEmp = selectCmdEmp.ExecuteReader())
                                                                    {
                                                                        while (mDrEmp.Read())
                                                                        {
                                                                            txtName.Text = mDrEmp.GetString("wholename");
                                                                        }
                                                                    }
                                                                    txtCode.Clear();
                                                                    txtCode.Focus();
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
                                            else
                                            {
                                                MessageBox.Show("Oops you've login already, please contact attendance manager for this scenario! :)");
                                                txtCode.Clear();
                                                txtCode.Focus();
                                            }
                                        }                                        
                                    }
                                    else
                                    {
                                        MessageBox.Show("Oops Mali!");
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Code! Your trying to guess :)");
                        }
                    }
                }                
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtCode.Text == "")
            {
                MessageBox.Show("Oops Null Value is not allowed!");
            }
            else
            {
                try
                {
                    using (MySqlConnection cnn = new MySqlConnection(connectionString))
                    {
                        MySqlCommand cmdchecker = new MySqlCommand("SELECT COUNT(*) FROM attendancecredentials WHERE att_code LIKE @codeid AND DATE(att_date) LIKE CURDATE()", cnn);
                        cmdchecker.Parameters.AddWithValue("@codeid", txtCode.Text);
                        cnn.Open();
                        int checkercnt = Convert.ToInt32(cmdchecker.ExecuteScalar());
                        if (checkercnt > 0)
                        {
                            //get data from id extracted in dgView
                            try
                            {
                                string selectQry = "SELECT employee from attendancecredentials WHERE att_code LIKE @codeid";
                                MySqlCommand selectCmd = new MySqlCommand(selectQry, cnn);
                                selectCmd.Parameters.AddWithValue("@codeid", txtCode.Text);
                                using (MySqlDataReader mDr = selectCmd.ExecuteReader())
                                {
                                    if (mDr.Read())
                                    {
                                        txtID.Text = mDr.GetString("employee");
                                        using (MySqlConnection cnn1 = new MySqlConnection(connectionString))
                                        {
                                            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM attendanceepinoy WHERE (DATE(in_time_am) LIKE CURDATE() OR DATE(in_time_pm) LIKE CURDATE()) AND employee LIKE @employeeid", cnn1);
                                            cmd.Parameters.AddWithValue("@employeeid", txtID.Text);
                                            cnn1.Open();
                                            int userCount = Convert.ToInt32(cmd.ExecuteScalar());
                                            if (userCount > 0)
                                            {
                                                using (MySqlConnection cnUpdateTimeOut = new MySqlConnection(connectionString))
                                                {
                                                    try
                                                    {
                                                        string qryUpdateTimeOut = "UPDATE attendanceepinoy SET out_time_am = '" + txtDateTime.Text + "' WHERE (DATE(in_time_am) LIKE CURDATE()) AND employee LIKE '" + txtID.Text + "'";
                                                        MySqlCommand cmdInsert = new MySqlCommand(qryUpdateTimeOut, cnUpdateTimeOut);
                                                        cnUpdateTimeOut.Open();
                                                        try
                                                        {
                                                            if (cmdInsert.ExecuteNonQuery() == 1)
                                                            {
                                                                dgView2Load();
                                                                using (MySqlConnection cnn2 = new MySqlConnection(connectionString))
                                                                {
                                                                    MySqlCommand selectCmdEmp = new MySqlCommand("SELECT CONCAT(first_name,' ',last_name) as wholename,id from employees WHERE id LIKE @empid", cnn2);
                                                                    selectCmdEmp.Parameters.AddWithValue("@empid", txtID.Text);
                                                                    cnn2.Open();
                                                                    using (MySqlDataReader mDrEmp = selectCmdEmp.ExecuteReader())
                                                                    {
                                                                        while (mDrEmp.Read())
                                                                        {
                                                                            txtName.Text = mDrEmp.GetString("wholename");
                                                                        }
                                                                    }
                                                                    txtCode.Clear();
                                                                    txtCode.Focus();
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
                                    }
                                    else
                                    {
                                        MessageBox.Show("Oops Mali!");
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Code! Your trying to guess :)");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtCode.Text == "")
            {
                MessageBox.Show("Oops Null Value is not allowed!");
            }
            else
            {
                try
                {
                    using (MySqlConnection cnn = new MySqlConnection(connectionString))
                    {
                        MySqlCommand cmdchecker = new MySqlCommand("SELECT COUNT(*) FROM attendancecredentials WHERE att_code LIKE @codeid AND DATE(att_date) LIKE CURDATE()", cnn);
                        cmdchecker.Parameters.AddWithValue("@codeid", txtCode.Text);
                        cnn.Open();
                        int checkercnt = Convert.ToInt32(cmdchecker.ExecuteScalar());
                        if (checkercnt > 0)
                        {
                            //get data from id extracted in dgView
                            try
                            {
                                string selectQry = "SELECT employee from attendancecredentials WHERE att_code LIKE @codeid";
                                MySqlCommand selectCmd = new MySqlCommand(selectQry, cnn);
                                selectCmd.Parameters.AddWithValue("@codeid", txtCode.Text);
                                using (MySqlDataReader mDr = selectCmd.ExecuteReader())
                                {
                                    if (mDr.Read())
                                    {
                                        txtID.Text = mDr.GetString("employee");
                                        using (MySqlConnection cnn1 = new MySqlConnection(connectionString))
                                        {
                                            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM attendanceepinoy WHERE (DATE(in_time_am) LIKE CURDATE() OR DATE(in_time_pm) LIKE CURDATE()) AND employee LIKE @employeeid", cnn1);
                                            cmd.Parameters.AddWithValue("@employeeid", txtID.Text);
                                            cnn1.Open();
                                            int userCount = Convert.ToInt32(cmd.ExecuteScalar());
                                            if (userCount > 0)
                                            {
                                                using (MySqlConnection cnUpdateTimeIn = new MySqlConnection(connectionString))
                                                {
                                                    try
                                                    {
                                                        MySqlCommand cmdInsert = new MySqlCommand("UPDATE attendanceepinoy SET in_time_pm = '" + txtDateTime.Text + "' WHERE (DATE(in_time_am) LIKE CURDATE() OR DATE(in_time_pm) LIKE CURDATE()) AND employee LIKE '" + txtID.Text + "'", cnUpdateTimeIn);
                                                        cnUpdateTimeIn.Open();
                                                        try
                                                        {
                                                            if (cmdInsert.ExecuteNonQuery() == 1)
                                                            {
                                                                dgView2Load();
                                                                using (MySqlConnection cnn2 = new MySqlConnection(connectionString))
                                                                {
                                                                    MySqlCommand selectCmdEmp = new MySqlCommand("SELECT CONCAT(first_name,' ',last_name) as wholename,id from employees WHERE id LIKE @empid", cnn2);
                                                                    selectCmdEmp.Parameters.AddWithValue("@empid", txtID.Text);
                                                                    cnn2.Open();
                                                                    using (MySqlDataReader mDrEmp = selectCmdEmp.ExecuteReader())
                                                                    {
                                                                        while (mDrEmp.Read())
                                                                        {
                                                                            txtName.Text = mDrEmp.GetString("wholename");
                                                                        }
                                                                    }
                                                                    txtCode.Clear();
                                                                    txtCode.Focus();
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
                                            } else
                                            {
                                                //insert time in pm
                                                using (MySqlConnection cnInsertTimeIn = new MySqlConnection(connectionString))
                                                {
                                                    try
                                                    {
                                                        MySqlCommand cmdInsert = new MySqlCommand("INSERT INTO  attendanceepinoy (in_time_pm) VALUES (@timeinpm)", cnInsertTimeIn);
                                                        cnInsertTimeIn.Open();
                                                        try
                                                        {
                                                            if (cmdInsert.ExecuteNonQuery() == 1)
                                                            {
                                                                dgView2Load();
                                                                using (MySqlConnection cnn2 = new MySqlConnection(connectionString))
                                                                {
                                                                    MySqlCommand selectCmdEmp = new MySqlCommand("SELECT CONCAT(first_name,' ',last_name) as wholename,id from employees WHERE id LIKE @empid", cnn2);
                                                                    selectCmdEmp.Parameters.AddWithValue("@empid", txtID.Text);
                                                                    cnn2.Open();
                                                                    using (MySqlDataReader mDrEmp = selectCmdEmp.ExecuteReader())
                                                                    {
                                                                        while (mDrEmp.Read())
                                                                        {
                                                                            txtName.Text = mDrEmp.GetString("wholename");
                                                                        }
                                                                    }
                                                                    txtCode.Clear();
                                                                    txtCode.Focus();
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
                                    }
                                    else
                                    {
                                        MessageBox.Show("Oops Mali!");
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Code! Your trying to guess :)");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtCode.Text == "")
            {
                MessageBox.Show("Oops Null Value is not allowed!");
            }
            else
            {
                try
                {
                    using (MySqlConnection cnn = new MySqlConnection(connectionString))
                    {
                        MySqlCommand cmdchecker = new MySqlCommand("SELECT COUNT(*) FROM attendancecredentials WHERE att_code LIKE @codeid AND DATE(att_date) LIKE CURDATE()", cnn);
                        cmdchecker.Parameters.AddWithValue("@codeid", txtCode.Text);
                        cnn.Open();
                        int checkercnt = Convert.ToInt32(cmdchecker.ExecuteScalar());
                        if (checkercnt > 0)
                        {
                            //get data from id extracted in dgView
                            try
                            {
                                string selectQry = "SELECT employee from attendancecredentials WHERE att_code LIKE @codeid";
                                MySqlCommand selectCmd = new MySqlCommand(selectQry, cnn);
                                selectCmd.Parameters.AddWithValue("@codeid", txtCode.Text);
                                using (MySqlDataReader mDr = selectCmd.ExecuteReader())
                                {
                                    if (mDr.Read())
                                    {
                                        txtID.Text = mDr.GetString("employee");
                                        using (MySqlConnection cnn1 = new MySqlConnection(connectionString))
                                        {
                                            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM attendanceepinoy WHERE (DATE(in_time_am) LIKE CURDATE() OR DATE(in_time_pm) LIKE CURDATE()) AND employee LIKE @employeeid", cnn1);
                                            cmd.Parameters.AddWithValue("@employeeid", txtID.Text);
                                            cnn1.Open();
                                            int userCount = Convert.ToInt32(cmd.ExecuteScalar());
                                            if (userCount > 0)
                                            {
                                                using (MySqlConnection cnUpdateTimeOut = new MySqlConnection(connectionString))
                                                {
                                                    try
                                                    {
                                                        MySqlCommand cmdInsert = new MySqlCommand("UPDATE attendanceepinoy SET out_time_pm = '" + txtDateTime.Text + "' WHERE (DATE(in_time_am) LIKE CURDATE() OR DATE(in_time_pm) LIKE CURDATE()) AND employee LIKE '" + txtID.Text + "'", cnUpdateTimeOut);
                                                        cnUpdateTimeOut.Open();
                                                        try
                                                        {
                                                            if (cmdInsert.ExecuteNonQuery() == 1)
                                                            {
                                                                dgView2Load();
                                                                using (MySqlConnection cnn2 = new MySqlConnection(connectionString))
                                                                {
                                                                    MySqlCommand selectCmdEmp = new MySqlCommand("SELECT CONCAT(first_name,' ',last_name) as wholename,id from employees WHERE id LIKE @empid", cnn2);
                                                                    selectCmdEmp.Parameters.AddWithValue("@empid", txtID.Text);
                                                                    cnn2.Open();
                                                                    using (MySqlDataReader mDrEmp = selectCmdEmp.ExecuteReader())
                                                                    {
                                                                        while (mDrEmp.Read())
                                                                        {
                                                                            txtName.Text = mDrEmp.GetString("wholename");
                                                                        }
                                                                    }
                                                                    txtCode.Clear();
                                                                    txtCode.Focus();
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
                                    }
                                    else
                                    {
                                        MessageBox.Show("Oops Mali!");
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Code! Your trying to guess :)");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                DataGridViewCell cell = null;

                foreach (DataGridViewCell selectedCell in dgView.SelectedCells)
                {
                    cell = selectedCell;
                    break;
                }
                if (cell != null)
                {
                    DataGridViewRow row = cell.OwningRow;
                    txtName.Text = row.Cells["wholename"].Value.ToString();
                }
            }
            catch (Exception)
            {

            }

        }

        private void dgView_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                TimeInAM.Focus();
            }
        }

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                button1_Click((object)sender, (EventArgs)e);
            }
            else if (e.KeyCode == Keys.F2)
            {
                button2_Click((object)sender, (EventArgs)e);
            }
            else if (e.KeyCode == Keys.F3)
            {
                button3_Click((object)sender, (EventArgs)e);
            }
            else if (e.KeyCode == Keys.F4)
            {
                button4_Click((object)sender, (EventArgs)e);
            }
        }

        private void attendanceSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var showFrm2 = new Form2();
            showFrm2.Show();        
        }

        private void dTRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var showFrm6 = new frmAddEmployeeAttendance();
            showFrm6.Show();
        }

        private void addDeductionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmShw3 = new frmAddDeduction();
            frmShw3.Show();
        }

        private void transactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmShw4 = new frmEmployeeDeduction();
            frmShw4.Show();
        }

        private void salaryComputationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmShw9 = new frmAddEmployerContribution();
            frmShw9.Show();
        }

        private void payrollToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frmShw8 = new frmPayroll();
            frmShw8.Show();
        }
    }
}
