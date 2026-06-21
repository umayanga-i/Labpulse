using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LabPulse
{
    public partial class studentDashboard : Form
    {
        private string currentUserName;
        public studentDashboard()
        {
            InitializeComponent();
        }
        public studentDashboard(string userName)
        {
            InitializeComponent();
            currentUserName = userName;
        }

        /// <summary>
        /// THE MASTER SWITCHING FUNCTION
        /// Strips top-level borders from sub-forms and embeds them directly into the pnlContent container.
        /// </summary>
        /// <param name="childForm">The instance of the target inner form to load.</param>
        private void DisplaySubForm(Form childForm)
        {
            // 1. If a form is already showing in the workspace panel, close it to free up memory
            if (pnlContent.Controls.Count > 0)
            {
                Form currentForm = pnlContent.Controls[0] as Form;
                if (currentForm != null)
                {
                    currentForm.Close();
                    currentForm.Dispose();
                }
                pnlContent.Controls.Clear();
            }

            // 2. Configure the incoming form to act as an embedded panel control
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // 3. Inject the form into the panel's active control collection
            pnlContent.Controls.Add(childForm);
            pnlContent.Tag = childForm;
            childForm.Show();
        }

        /// <summary>
        /// Form Load event execution flow.
        /// Runs automatically the moment the studentDashboard finishes initial rendering.
        /// </summary>
        private void studentDashboard_Load(object sender, EventArgs e)
        {
            DisplaySubForm(new FrmEquipmentCatalog());
        }

        private void btnCatalog_Click(object sender, EventArgs e)
        {
            DisplaySubForm(new FrmEquipmentCatalog());
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            DisplaySubForm(new FrmBookingHistory());
        }

        private void btnRules_Click(object sender, EventArgs e)
        {
            DisplaySubForm(new FrmLabRules());
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            DisplaySubForm(new FrmProfileSettings());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to log out of LabPulse?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}