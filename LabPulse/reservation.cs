using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LabPulse
{
    public partial class reservation : Form
    {
        private Form dashboardInstance;
        public reservation()
        {
            InitializeComponent();
        }

        public reservation(string equipmentName, string equipmentId, Form callingDashboard)
        {
            InitializeComponent();
            this.dashboardInstance = callingDashboard;

            // Wires up the passed strings directly to your UI display components
            // textBox1.Text = equipmentName;
            // textBox2.Text = equipmentId;
        }

        private void reservation_Load(object sender, EventArgs e)
        {
            // Initial component allocations go here
        }

        // 4. Safe Return Path: Handles returning to dashboard if they click the upper-right 'X'
        private void reservation_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.dashboardInstance != null)
            {
                this.dashboardInstance.Show();
            }
        }

        private void reservation_Load_1(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 1. Confirm with the user before abandoning their current action
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit and return to the main home screen?",
                "Return Home",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                // 2. Initialize and display the primary welcome entry form
                Form1 welcomeScreen = new Form1();
                welcomeScreen.Show();

                // 3. Clear out the hidden parent dashboard so it isn't left running in memory
                if (this.dashboardInstance != null)
                {
                    // Detach the FormClosed event from the dashboard temporarily 
                    // to prevent any accidental application loop locks
                    this.FormClosed -= reservation_FormClosed;

                    this.dashboardInstance.Close();
                }

                // 4. Close the Reservation form itself
                this.Close();
            }
        }
    }
}
