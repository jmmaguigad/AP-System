using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance
{
    public partial class frmMain : Form
    {
        private int childFormNumber = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void printAttendanceDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 showFrm2 = new Form2();
            showFrm2.MdiParent = this.ParentForm;
            showFrm2.Show();
        }

        private void addAttendanceDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEmployeeAttendance showFrm6 = new frmAddEmployeeAttendance();
            showFrm6.MdiParent = this.ParentForm;
            showFrm6.Show();
        }

        private void deductionDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddDeduction frmShw3 = new frmAddDeduction();
            frmShw3.MdiParent = this.ParentForm;
            frmShw3.Show();
        }

        private void employeeDeductionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployeeDeduction frmShw4 = new frmEmployeeDeduction();
            frmShw4.MdiParent = this.ParentForm;
            frmShw4.Show();
        }

        private void employerContributionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEmployerContribution frmShw9 = new frmAddEmployerContribution();
            frmShw9.MdiParent = this.ParentForm;
            frmShw9.Show();
        }

        private void employeePayrollToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPayroll frmShw8 = new frmPayroll();
            frmShw8.MdiParent = this.ParentForm;
            frmShw8.Show();
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            frmAttendance frm1 = new frmAttendance();
            frm1.MdiParent = this.ParentForm;
            frm1.Show();
        }
    }
}
