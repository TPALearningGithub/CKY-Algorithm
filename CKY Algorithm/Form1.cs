using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CKY_Algorithm
{
    public partial class frmMain : Form
    {
        private CNFGrammar Grm = new CNFGrammar(Properties.Resources.CNFRules);
        private bool readyMove = false;
        private Point startPoint = new Point(), endPoint = new Point();
        private string backupGramma = string.Empty;
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Grm = new CNFGrammar(tbxRules.Text);
            tbxCYKResult.Text = Grm.GetCKYMatrixAsStringFor(tbxSentence.Text);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            tbxRules.Text = Grm.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlTitle_MouseUp(object sender, MouseEventArgs e)
        {
            readyMove = false;
        }

        private void pnlTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (readyMove)
            {
                Location = new Point(Location.X + e.X - startPoint.X, Location.Y + e.Y - startPoint.Y);
            }
        }

        private void TurnOnEditMode()
        {
            backupGramma = tbxRules.Text;
            btnEdit.Enabled = false;
            tbxRules.ReadOnly = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnRun.Enabled = false;
        }

        private void TurnOffEditMode()
        {
            tbxRules.ReadOnly = true;
            btnEdit.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnRun.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            TurnOnEditMode();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TurnOffEditMode();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tbxRules.Text = backupGramma;
            TurnOffEditMode();
        }

        private void pnlTitle_MouseDown(object sender, MouseEventArgs e)
        {
            readyMove = true;
            startPoint = e.Location;
        }
    }
}
